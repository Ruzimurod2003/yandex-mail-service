// настройка логина, пароля отправителя
using System.Net.Mail;

var from = "mathruz@yandex.com"; // Здесь мы указываем, кто его отправляет
var to = "ruzimurodabdunazarov2003@mail.ru"; // Здесь вводим, кого отправляют,
// Также есть инструкция по получению информации о пароле в файле notes.txt.
var pass = "some_password"; 

// адрес и порт smtp-сервера, с которого мы и будем отправлять письмо
SmtpClient client = new SmtpClient("smtp.yandex.ru", 25);

client.DeliveryMethod = SmtpDeliveryMethod.Network;
client.UseDefaultCredentials = false;
client.Credentials = new System.Net.NetworkCredential(from, pass);
client.EnableSsl = true;

// создаем письмо: message.Destination - адрес получателя
var mail = new MailMessage(from, to);
mail.Subject = "test subject";
mail.Body = "<b>Hello Ruzimurod</b>";
mail.IsBodyHtml = true;

await client.SendMailAsync(mail);