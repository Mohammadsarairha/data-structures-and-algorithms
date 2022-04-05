using System;
using Xunit;
using Linked_list_zip;

namespace Test_Zip_List
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(3);
            list.Append(2);


            LinkedList list1 = new LinkedList();
            list1.Append(5);
            list1.Append(9);
            list1.Append(4);


            LinkedList list2 = new LinkedList();
            list2.Append(1);
            list2.Append(5);
            list2.Append(3);

            LinkedList zip = LinkedList.ZipLists(list, list1);

            Assert.Equal(zip.head.Next.Value,list2.head.Next.Value);
        }
    }
}
