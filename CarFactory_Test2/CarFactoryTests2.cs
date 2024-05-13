using System;
using CarFactoryLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory_Test2
{
    public class CarFactoryTests2
    {
        [Fact]
        public void NewCar_CarTypeToyota_Toyota()
        {
            //type
            Car? car = CarFactory.NewCar(CarTypes.Toyota);
            Assert.IsAssignableFrom<Car>(new Toyota());

        }
        [Fact]
        public void NewCar_CarTypeHonda_Exception()
        {
            Assert.Throws<NotImplementedException>(() =>
            {
                // Act
                Car? result = CarFactory.NewCar(CarTypes.Honda);
            });
        }
    }
}
