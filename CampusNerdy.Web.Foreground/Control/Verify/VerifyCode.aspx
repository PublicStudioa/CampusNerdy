<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<!-- 这个页面用于来生成验证码-->
<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

        CampusNerdy.Bll.VerifyGen.VerifyGenEngine gen = new CampusNerdy.Bll.VerifyGen.VerifyGenEngine();

        string verifyCode = gen.CreateVerifyCode(4, 0);//这儿代表4个字母,0个中文.

        Session["Code"] = verifyCode.ToUpper();

        System.Drawing.Bitmap bitmap = gen.CreateImage(verifyCode);

        System.IO.MemoryStream ms = new System.IO.MemoryStream();

        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

        Response.Clear();

        Response.ContentType = "image/Png";

        Response.BinaryWrite(ms.GetBuffer());

        bitmap.Dispose();

        ms.Dispose();

        ms.Close();

        Response.End();

    }

</script>
