using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestProjectXUnitVijaySales.Utility;

namespace ECommerceBPOScenarios
{

    //C# Variables: int ,float, double, char, long, bool
    //C# Types: class , struct, interface, enum, delegate, event
    
    //C# inbuilt class: 
    //                  Console, String , etc.
    // Collection Classes:
    // inbuilt namespaces:
    //          System.Collection.Generic
    //                  List, Queue, Dictionary, Stack, Hashtable, etc.
    //          System.IO
    //                  FileStream, BufferReader, BuffterWriter, etc.
    //                  File, FileInfo
    //          System.Text
    //
    //          System.Data
    //............................




    public  class TestOrderProcessing
    {
        [Fact]
        public static  void CurrentDayTest()
        {
            
            DateTime dateTime = DateTime.Now;
           
            int expectedDay = 19;

            int actualDay = dateTime.Day;
 
            Assert.Equal(expectedDay, actualDay);
        }

        [Fact]
        public   void OrderCollectionTest()
        {


            FlowersUtility mgr=new FlowersUtility();
            List<string> allFlowers=mgr.GetTodayFreshFlowers();

            //..............
            //...............

            //................
            Assert.Equal(56, 1);

        }

        [Fact]
        public void OrderCancellationTest()
        {

            FlowersUtility mgr = new FlowersUtility();
            List<string> allFlowers = mgr.GetTodayFreshFlowers();

            Assert.Equal(56, 1);

        }


        [Fact]
        public void OrderApprovalTest()
        {
            Assert.Equal(56, 1);

        }

    }
}
