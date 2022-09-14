using WebAppDETAug2022_.Models;
using WebAppDETAug2022_.Service;
using WebAppDETAug2022_;


using Xunit;


namespace MyFirstUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetAllPizzas()
        {
            int expected = 2;
            int actual = PizzaService.GetAll().Count;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_AddPizza()
        {
            Pizza p = new Pizza { Name = "xxx", Size = PizzaSize.Medium, IsGlutenFree = true };
            PizzaService.Add(p);
            Pizza verify = PizzaService.Get(3);
            Assert.Equal(3, PizzaService.GetAll().Count);
            Assert.NotNull(verify.Id);

        }

        [Fact]
        public void Test_DeletePizza()
        {
            PizzaService.Delete(3);
            Assert.Equal(2, PizzaService.GetAll().Count);
        }

        [Fact]
        public void Test_UpdatePizza()
        {
            Pizza p = new Pizza { Id = 2, Name = "Italian Magic", Size = PizzaSize.Medium, IsGlutenFree = true };
            PizzaService.Update(p);
            Pizza verify = PizzaService.Get(2);
            Assert.Equal(verify.Name, "Italian Magic");
        }


    }
}