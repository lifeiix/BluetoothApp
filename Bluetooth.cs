using System;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
namespace BT_UP
{
    class Bluetooth
    {
        public int parseNumber = 5;
        public BluetoothRadio[] bluetoothRadios;
        public static BluetoothClient bluetoothClient;
        public BluetoothDeviceInfo[] bluetoothDeviceInfo;
        public BluetoothDeviceInfo device;
        private BluetoothEndPoint bluetoothEndPoint;
        public BluetoothRadio bluetoothRadio;
        //public string password = "123456";
        public string password = "1234";
        public static NetworkStream peerStream;
        //private ThreadStart bluetoothReadThreadStart;
        private Thread bluetoothReadThread;
        private static Mutex mut = new Mutex();

        public Bluetooth() //konsturktor
        {
            bluetoothRadio = null;
        }

        ~Bluetooth()
        {
            mut.Dispose();
        }
        public void UpdateAdapters() //pobranie listy adatperow
        {
            bluetoothRadios = BluetoothRadio.AllRadios;
        }
        public void FindDevices(bool Authenticate, bool Remembered, bool Unknown) //szukanie urzadzen
        {
            bluetoothEndPoint = new BluetoothEndPoint(bluetoothRadio.LocalAddress, BluetoothService.SerialPort);
            bluetoothClient = new BluetoothClient(bluetoothEndPoint);
            bluetoothDeviceInfo = bluetoothClient.DiscoverDevices(50, Authenticate, Remembered, Unknown);
            bluetoothClient.Close();
        }

        public static void BluetoothReadProcess()
        {
            while (bluetoothClient.Connected)
            {
                byte[] buffer = new byte[64];
                int readlen = 0;

                try
                {
                    mut.WaitOne();
                    if (peerStream.DataAvailable)
                    {
                        readlen = peerStream.Read(buffer, 0, 16);
                        peerStream.Flush();

                        Console.WriteLine("readlen: {0}", readlen);
                        for (int i = 0; i < readlen; i++)
                        {
                            Console.WriteLine("buf[{0}] = {1}", i, buffer[i].ToString("X"));
                        }
                    }
                    mut.ReleaseMutex();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public bool ConnectToDevice() //parowanie urzadzenia
        {
            if (bluetoothClient != null && bluetoothClient.Connected)
            {
                return true;
            }

            byte[] buffer = new byte[16];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (byte)i;
                Console.WriteLine("buffer[{0}]= {1}", i, buffer[i]);
            }

            //device.Update();
            //device.Refresh();
            device.SetServiceState(BluetoothService.ObexObjectPush, true);

            //device.SetServiceState(BluetoothService.SerialPort, true);
            //BluetoothSecurity.SetPin(device.DeviceAddress, @"1234");
            //if (!BluetoothSecurity.PairRequest(device.DeviceAddress, @"1234"))
            //{
            //    MessageBox.Show("Connect failed");
            //}
            //else
            //{
            //    MessageBox.Show("Connect ok");
            //}

            Thread.Sleep(100);

            // 初始化蓝牙客户端
            bluetoothClient = new BluetoothClient(bluetoothEndPoint);

            // 对目标设备发起蓝牙连接
            // 蓝牙连接有一定概率会失败，需要多次连接
            int retry = 0;
            do
            {
                try
                {
                    //BluetoothEndPoint remoteBluetoothEP = new BluetoothEndPoint(device.DeviceAddress, BluetoothService.SerialPort);
                    //bluetoothClient.Connect(remoteBluetoothEP);
                    bluetoothClient.Connect(device.DeviceAddress, BluetoothService.SerialPort);
                    Thread.Sleep(100);
                    if (bluetoothClient.Connected)
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    //MessageBox.Show(e.Message);
                    Console.WriteLine(e.Message);
                }
            } while (retry++ < 5);

            //Thread.Sleep(100);
            //MessageBox.Show(bluetoothClient.Connected.ToString());
            if (!bluetoothClient.Connected)
            {
                MessageBox.Show("蓝牙连接失败");
            }
            else
            {
                // 创建流进行数据读写操作
                peerStream = bluetoothClient.GetStream();
                try
                {
                    peerStream.Flush();
                    peerStream.Write(buffer, 0, buffer.Length);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    //peerStream.Close();
                }

                bluetoothReadThread = new Thread(new ThreadStart(BluetoothReadProcess));
                bluetoothReadThread.Start();
            }

            //device.Update();
            //device.Refresh();
            //Thread.Sleep(100);

            return bluetoothClient.Connected;
        }

        public bool DisconnectDevice()
        {
            if (bluetoothClient != null && !bluetoothClient.Connected)
            {
                return false;
            }

            // 终止蓝牙读线程
            bluetoothReadThread.Abort();

            // 断开蓝牙连接
            bluetoothClient.Dispose();
            Thread.Sleep(100);

            return bluetoothClient.Connected;
        }

        public void SendFile(string fileName)//wysylanie pliku
        {
            int iteration = 0;
            while (iteration < parseNumber)
            {
                try
                {
                    var requestUri = new Uri("obex://" + device.DeviceAddress + "/" + fileName);
                    ObexWebRequest request = new ObexWebRequest(requestUri);
                    request.ReadFile(fileName);
                    ObexWebResponse response = (ObexWebResponse)request.GetResponse();
                    response.Close();
                    iteration = parseNumber;
                    MessageBox.Show("Transfer udany.");
                }
                catch
                {
                    iteration++; //iterowanie po zmiennej, trzymanie sie ustlaonej ilosci prob
                    if (iteration == parseNumber - 1)
                        MessageBox.Show("Błąd transferu.");
                }

            }
        }
    }
}
