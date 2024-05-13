using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory_Test2
{
    public class BMWTest
    {
        [Fact]
        public void IsStopped_velocity20_false()
        {
            //Boolean
            BMW bMW = new BMW();
            bMW.velocity = 20;
            bool result = bMW.IsStopped();
            Assert.False(result);
        }
        [Fact]
        public void GetDirection_DirectionBackWord_Backword()
        {
            //String
            BMW bMW = new BMW();
            bMW.drivingMode = DrivingMode.Backward;
            string result = bMW.GetDirection();

            Assert.Contains("Ba", result);
            Assert.EndsWith("rd", result);
            Assert.StartsWith("Ba", result);
            Assert.DoesNotContain("mm", result);
            Assert.DoesNotMatch("\\b(\\w)(\\w)\\w*\\2\\1\\b\r\n", result);
        }
        [Fact]
        public void TimeToCoverDistance_Velocity50Dis100_2()
        {
            //Numeric
            BMW bMW = new BMW();
            bMW.velocity = 50;
            double distance = 100;
            bMW.TimeToCoverDistance(distance);

            Assert.InRange(bMW.velocity, 20, 70);
            Assert.NotStrictEqual(bMW.velocity, 70);
        }
        [Fact]
        public void GetMyCar_callFunction_SameCar()
        { //Refernce 
            BMW bMW = new BMW();
            BMW bMW2 = new BMW();
            Car car = bMW.GetMyCar();
            Assert.NotNull(car);
            Assert.NotSame(car, bMW2);
            Assert.Same(car, bMW);
        }
    }
}
