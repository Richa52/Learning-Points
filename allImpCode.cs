patelpalak8176@gmail.com
palak.kpatel@gatewaytechnolabs.com

In JavaScript,
String.fromCharCode(e.keyCode); // Will not work in FF 
String.fromCharCode(e.charCode); // Will work in FF 


So you can use this
var code = e.charCode || e.keyCode;
String.fromCharCode(code); // Will work in all browsers 
---------------------------------------------------

C# 6.0 New Feature...FYI

// OLD Logic
Public dynamic MethodName(BranchModel branch)
{
  if(branch != null)  
 {
  if(branch.BranchName != null) 
  {
   ... 
   ...
  }
 }
}

// NEW Logic
Public dynamic MethodName(BranchModel branch)
{
 if(branch?.BranchName != null) 
 {
  ...
  ...
 }
}

-------------------------------------------------------------------
C# 6.0 new feature...

old logic....
 String.format("({0},{1})",X,Y); 

new logic....
 $"({X},{Y})"; 

-------------------------------------------------------------------
reference : https://channel9.msdn.com/Series/ConnectOn-Demand/211#time=0s

---------------------------------------
 Simple Regex Understanding... 

var rege = /^[1-9][0-9]{3} ?(?!sa|sd|ss)[a-z]{2}$/i;

^ matches beginning of string
[1-9][0-9]{3} matches a single non-zero digit, and three 0-9 digits
? matches 0 or 1 spaces (you could use * to match 0 or more spaces)
(?!sa|sd|ss) is a lookahead test to check that the remainder is not "sa", "sd", or "ss".
[a-z]{2} matches 2 a-z characters
$ matches the end of the string
i at the end is the case-insensitive modifier

--------------------------------------------------------------------
to send email from gmail using c#

  protected string SendEmail(string toAddress, string subject, string body)
   {
     string result = “Message Sent Successfully..!!”;
     string senderID = “SenderEmailID“;// use sender’s email id here..
     const string senderPassword = “Password“; // sender password here…
     try
     {
       SmtpClient smtp = new SmtpClient
       {
         Host = “smtp.gmail.com“, // smtp server address here…
         Port = 587,
         EnableSsl = true,
         DeliveryMethod = SmtpDeliveryMethod.Network,
         Credentials = new System.Net.NetworkCredential(senderID, senderPassword),
         Timeout = 30000,
       };
       MailMessage message = new MailMessage(senderID, toAddress, subject, body);
       smtp.Send(message);
     }
     catch (Exception ex)
     {
       result = “Error sending email.!!!”;
     }
     return result;
   }
