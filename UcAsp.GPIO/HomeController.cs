using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Gpio;
using Unosquare.Swan;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UcAsp.GPIO
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Get()
        {
            IReadOnlyCollection<GpioPin> list = Pi.Gpio.Pins;
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (GpioPin pin in list)
            {
                GpioPinValue value = pin.ReadValue();
                dic.Add(pin.PinNumber.ToString(), (int)value);
            }
            return Json(dic);
        }

        public IActionResult Post()
        {
            try
            {

                string item = Request.Form["gpio"];
                string value = Request.Form["value"];
                GpioPin gpio = GetGpioPin(item);
                if (value == "true")
                {
                    gpio.Write(true);
                    gpio.Write(GpioPinValue.High);
                }
                else
                {
                    gpio.Write(false);
                    gpio.Write(GpioPinValue.Low);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return Json(new { result = true });
        }

        public GpioPin GetGpioPin(string i)
        {
            GpioPin gpio = Pi.Gpio.Pin00;
            switch (i)
            {
                case "1":
                case "01":
                    Pi.Gpio.Pin01.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin01;
                    break;


                case "2":
                case "02":
                    Pi.Gpio.Pin02.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin02;
                    break;
                case "3":
                case "03":
                    Pi.Gpio.Pin03.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin03;
                    break;
                case "4":
                case "04":
                    Pi.Gpio.Pin04.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin04;
                    break;
                case "5":
                case "05":
                    Pi.Gpio.Pin05.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin05;
                    break;
                case "6":
                case "06":
                    Pi.Gpio.Pin06.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin06;
                    break;
                case "7":
                case "07":
                    Pi.Gpio.Pin07.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin07;
                    break;
                case "8":
                case "08":
                    Pi.Gpio.Pin08.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin08;
                    break;
                case "9":
                case "09":
                    Pi.Gpio.Pin09.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin09;
                    break;
                case "10":
                    Pi.Gpio.Pin10.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin10;
                    break;
                case "11":
                    Pi.Gpio.Pin11.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin11;
                    break;
                case "12":
                    Pi.Gpio.Pin12.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin12;
                    break;
                case "13":
                    Pi.Gpio.Pin13.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin13;
                    break;
                case "14":
                    Pi.Gpio.Pin14.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin14;
                    break;
                case "15":
                    Pi.Gpio.Pin15.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin15;
                    break;
                case "16":
                    Pi.Gpio.Pin16.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin16;
                    break;
                case "17":
                    Pi.Gpio.Pin17.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin17;
                    break;
                case "18":
                    Pi.Gpio.Pin18.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin18;
                    break;
                case "19":
                    Pi.Gpio.Pin19.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin19;
                    break;
                case "20":
                    Pi.Gpio.Pin20.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin20;
                    break;
                case "21":
                    Pi.Gpio.Pin21.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin21;
                    break;
                case "22":
                    Pi.Gpio.Pin22.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin22;
                    break;
                case "23":
                    Pi.Gpio.Pin23.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin23;
                    break;
                case "24":
                    Pi.Gpio.Pin24.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin24;
                    break;
                case "25":
                    Pi.Gpio.Pin25.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin25;
                    break;
                case "26":
                    Pi.Gpio.Pin26.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin26;
                    break;
                case "27":
                    Pi.Gpio.Pin27.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin27;
                    break;
                case "28":
                    Pi.Gpio.Pin28.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin28;
                    break;
                case "29":
                    Pi.Gpio.Pin29.PinMode = GpioPinDriveMode.Output;
                    gpio = Pi.Gpio.Pin29;
                    break;
                default:
                    gpio = Pi.Gpio.Pin00;
                    break;
            }

            return gpio;
        }
    }
}
