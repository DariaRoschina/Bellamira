using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Globalization;
using System.Security.Cryptography;
namespace WebClient.Account
{
    public partial  class pay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            // Generate rows and cells.           
            int numrows = 3;
            int numcells = 2;
            for (int j = 0; j < numrows; j++)
            {
                TableRow r = new TableRow();
                for (int i = 0; i < numcells; i++)
                {
                    TableCell c = new TableCell();
                    //c.Controls.Add(new LiteralControl("row "
                    //    + j.ToString() + ", cell " + i.ToString()));
                    c.Controls.Add(new LiteralControl(IceApplication.getInstance().SessionPrx.getGroupManager().getAllGroups().ToString()));
                    r.Cells.Add(c);
                }
                Table1.Rows.Add(r);
            }
        }

        //    // регистрационная информация (логин, пароль #1)
        //    // registration info (login, password #1)
        //    string sMrchLogin = "demo";
        //    string sMrchPass1 = "password_1";

        //    // номер заказа
        //    // number of order
        //    int nInvId = 0;

        //    // описание заказа
        //    // order description
        //    string sDesc = "Пополнение счета ROBOKASSA";

        //    // сумма по умолчания в форме ввода
        //    // default sum 
        //    string sDefaultSum = "10";

        //    // тип товара
        //    // code of goods
        //    string sShpItem = "2";

        //    // язык
        //    // language
        //    string sCulture = "ru";

        //    // кодировка
        //    // encoding
        //    string sEncoding = "utf-8";

        //    // формирование подписи
        //    // generate signature
        //    string sCrcBase = string.Format("{0}::{1}:{2}:shp_Item={3}",
        //                        sMrchLogin, nInvId, sMrchPass1, sShpItem);

        //    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        //    byte[] bSignature = md5.ComputeHash(Encoding.UTF8.GetBytes(sCrcBase));

        //    StringBuilder sbSignature = new StringBuilder();
        //    foreach (byte b in bSignature)
        //        sbSignature.AppendFormat("{0:x2}", b);

        //    string sCrc = sbSignature.ToString();

        //    // HTML-страница с кассой
        //    // ROBOKASSA HTML-page
        //    // ltKassa is System.Web.UI.WebControls.Literal;

        //lll.Text = "<script language=JavaScript " +
        //                            "src=\"https://auth.robokassa.ru/Merchant/PaymentForm/FormFLS.js?" +
        //                            "MerchantLogin=" + sMrchLogin +
        //                            "&DefaultSum=" + sDefaultSum +
        //                            "&InvoiceID=" + nInvId +
        //                            "&shp_Item=" + sShpItem +
        //                            "&SignatureValue=" + sCrc +
        //                            "&Description=" + sDesc +
        //                            "&Culture=" + sCulture +
        //                            "&Encoding=" + sEncoding + "\"></script>";
    }
}
    

    
