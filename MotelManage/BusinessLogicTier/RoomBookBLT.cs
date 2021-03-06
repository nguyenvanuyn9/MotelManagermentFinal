﻿using MotelManage.DataAccessTier;
using MotelManage.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManage.BusinessLogicTier
{
    class RoomBookBLT
    {
         private RoomBookDAT roomBookDAT;

         public RoomBookBLT()
        {
            this.roomBookDAT = new RoomBookDAT();
        }

        public DataTable getListData()
        {
            DataTable table = roomBookDAT.getListData();

            return table;
        }

        public DataTable searchRoomBook(RoomBook roomBook, string customerName="")
        {
            try
            {                
                DataTable table = roomBookDAT.SearchRoomBook(roomBook, customerName);

                return table;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
   
        

        public bool deleteRoomBook(String id)
        {
            return roomBookDAT.deleteRoomBook(id);
        }

        public bool addRoomBook(RoomBook roomBook)
        {
            return roomBookDAT.addRoomBook(roomBook);

            //Cap nhat lai trang thai phong -->Thue
        }



        public bool updateRoomBook(RoomBook roomBook)
        {
            return roomBookDAT.updateRoomBook(roomBook);

            //update lai trang thai phong cu -->> TRong
            //phong moi -->>Thue
        }

        //==================================

        public String getNameRoomById(String id)
        {
            return roomBookDAT.getNameRoomById(id);
        }

        public DataTable getListRoom()
        {
            return roomBookDAT.getListRoom();
        }

        public DataTable getListRoomAvaiable(String status)
        {
            return roomBookDAT.getListRoomAvaiable(status);
        }

        public DataTable getListCustomer()
        {
            return roomBookDAT.getListCustomer();
        }

        public DataTable getListRoomBookStatus()
        {
            return roomBookDAT.getListRoomBookStatus();
        }

        public bool updateRoomBookDelay(String statusId, String now)
        {
            return roomBookDAT.updateRoomBookDelay(statusId, now);
        }

    }
}
