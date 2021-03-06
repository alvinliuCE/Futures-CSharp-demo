 using Huobi.Rest.CSharp.Demo;
using Huobi.Rest.CSharp.Demo.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;


namespace Huobi.Rest.CSharp.Demo.Tests
{
    [TestClass()]
    public class HuobiApiTests
    {	//accessKey: 
		//secretKey:  
        HuobiApi api = new HuobiApi("XXXXX", "XXXXX");
          [TestMethod()]
          public void GetAllAccountTest()
          {
          var result = api.GetContractInfo();
          Assert.IsNotNull(result);
         }

        [TestMethod()]
        public void OrderPlaceTest()
        {

            OrderPlaceRequest req = new OrderPlaceRequest();
            req.volume = "1";
            req.direction = "buy";
            req.price = "100";
            req.offset = "open";
            req.lever_rate = "10";
            req.contract_code = "BTC181214";
            req.order_price_type = "limit";
            req.symbol = "BTC";
            req.contract_type = "this_week";
            var result = api.OrderPlace(req);
           Assert.AreEqual(result.Status, "ok");
        }

         [TestMethod()]
          public void OrderPositionTest()
         {
         OrderPositionRequest req = new OrderPositionRequest();
         req.symbol = "BTC";

           var result = api.OrderPosition(req);
          Assert.AreEqual(result.Status, "ok");
          }
    }
}
