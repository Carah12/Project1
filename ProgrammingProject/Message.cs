using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProgrammingProject
{
    class Message
    {
        private DateTime time;
        private int userID;
        private string messageToRead;

        public DateTime Time { get => time; set => time = value; }
        public int UserID { get => userID; set => userID = value; }
        public string MessageToRead { get => messageToRead; set => messageToRead = value; }

        public Message(DateTime time, int userID, string messageToRead)
        {
            this.time = time;
            this.userID = userID;
            this.messageToRead = messageToRead;
        }

        public Message()
        {

        }

        public List<Message> PopulateMessage()
        {
            List<Message> messageList = new List<Message>();
            DataSet rawData = new DataSet();
            DBAccess dba = new DBAccess();

            rawData = dba.ReadData("tblMessage");
            foreach (DataRow item in rawData.Tables["tblMessage"].Rows)
            {
                messageList.Add(new Message(DateTime.Parse(item["DecryptionTime"].ToString()), int.Parse(item["UserID"].ToString()), item["Message"].ToString()));

            }
            return messageList;
        }
    }
}
