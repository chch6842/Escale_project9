using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace escale.Controllers
{
  public class AnalysisController : Controller
  {
    [HttpGet]
    public ActionResult Index()
    {
      var model = new ScaleData();
      return View(model);
    }

    [HttpPost]
    public ActionResult Index(ScaleData model)
    {
      if (!ModelState.IsValid) return View(model);
      //取得使用者資料
      model.UserNo = SessionService.UserNo;
      var user = new z_sqlUsers();
      var userData = user.GetData(model.UserNo);

      //儲存至資料庫
      var scale = new z_sqlScaleData();
      scale.Create(model);

      //寄送電子郵件
      var mailObject = new MailObject();
      mailObject.ToName = userData.UserName;
      mailObject.ToEmail = userData.ContactEmail;
      var sendEmail = new SendMailService();
      string str_message = sendEmail.AnalysisScale(mailObject, model);

      //顯示訊息
      if (string.IsNullOrEmpty(str_message)) str_message = "您的營養分析結果已經寄出，請查收!!";
      SessionService.MessageText = str_message;
      return RedirectToAction("Index", "Message", new { area = "" });
    }
  }
}
