using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DBL
{
   public class MessageDBL
    {
        MessageDAL oMessageDAL = new MessageDAL();
        public POCO.Message D_Message_Insert(POCO.Message PoMessage)
        {
            DataSet ds = new DataSet();
            POCO.Message oMessage = new POCO.Message();
            ds = oMessageDAL.D_Messages_Insert(PoMessage.MessageBody, PoMessage.FromUser, PoMessage.MessageIcon,PoMessage.FromDate,PoMessage.ToDate);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    oMessage.MessageId = (int)ds.Tables[0].Rows[0]["MessageId"];
                    oMessage.MessageBody = ds.Tables[0].Rows[0]["MessageBody"].ToString();
                    oMessage.FromUser = ds.Tables[0].Rows[0]["FromUser"].ToString();
                    oMessage.MessageIcon = ds.Tables[0].Rows[0]["MessageIcon"].ToString();
                    oMessage.FromDate = (DateTime) ds.Tables[0].Rows[0]["FromDate"];
                    oMessage.ToDate =(DateTime) ds.Tables[0].Rows[0]["ToDate"];
                }

            }
            return oMessage;

        }
        // Edit(Post)
        public void D_MessagesUsers_Update(POCO.Message Pomessage)
        {
            oMessageDAL.D_MessagesUsers_Update(Pomessage.MessageId, Pomessage.MessageBody, Pomessage.MessageIcon, Pomessage.FromDate, Pomessage.ToDate);
        }

      
    }
}
