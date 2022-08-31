using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CSRegler.Services
{
    public class GetTemp
    {
        public string theTempC = string.Empty;
        public string theTempF = string.Empty;
        /*
                int OPEN_READ_WRITE = 2;
                public string errorMessage = "OK";
                [DllImport("libc.so.6", EntryPoint = "open")]
                private static extern int Open(string fileName, int mode);
                [DllImport("libc.so.6", EntryPoint = "ioctl", SetLastError = true)]
                private static extern int Ioctl(int fd, int request, int data);
                [DllImport("libc.so.6", EntryPoint = "read", SetLastError = true)]
                private static extern int Read(int handle, byte[] data, int length);
                [DllImport("libc.so.6", EntryPoint = "write", SetLastError = true)]
                private static extern int Write(int handle, byte[] data, int length);
        */
        Random rand = new Random();
        public void GetTheTemp()
        {
            /*
            try
            {
                int I2C_CLIENT = 0x0703;            // read from I2C device bus 1
                int i2cHandle = Open("/dev/i2c-1", OPEN_READ_WRITE);
                // open the device at address 0x1A for communication
                int registerAddress = 0x1A;
                int deviceReturnCode = Ioctl(i2cHandle, I2C_CLIENT, registerAddress);            //set byte arrays for specifying  the 			register and reading the data
                byte[] deviceData = new byte[2];
                byte[] reg = new byte[1];
                //we have to tell it to read register 0x05
                reg[0] = 0x05;
                deviceReturnCode = Write(i2cHandle, reg, 1);
                //now we can read 2 bytes
                deviceReturnCode = Read(i2cHandle, deviceData, deviceData.Length);
                int msb = deviceData[0];  //most significant byte
                int lsb = deviceData[1];  //least significant byte
                                          //calculate according to the datasheet
                msb = msb & 0x1F;
                double tempc = (msb * 256) + lsb;
                if (tempc > 4095)  //positive
                    tempc -= 8192;//remove sign bit
                tempc *= .0625;
                //and a little high school physics for F
                double tempf = 32 + tempc * 9 / 5;
                theTempC = Convert.ToInt32(tempc).ToString();
                theTempF = Convert.ToInt32(tempf).ToString();
            }
            catch (Exception e)
            {
                errorMessage = e.ToString();
                  //so we can see the exception
            }*/

        theTempC = rand.Next(0, 60).ToString();
        theTempF = rand.Next(20, 100).ToString();
        }
    }
}
