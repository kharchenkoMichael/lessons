using Lesson1;
var account = new Account();
var mobilePhone = new MobilePhone();
var mail = new Mail();

account.SendNotification += mobilePhone.ShowNotification;
account.SendNotification += mail.SendMessage;

account.Give(100);
account.Take(50);
account.Take(70);

account.SendNotification -= mobilePhone.ShowNotification;
account.Take(30);
account.Give(40);
account.Take(80);

