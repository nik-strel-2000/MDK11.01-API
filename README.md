# MDK11.01-API
Для Автоматического создания Моделей по Базе данных необходимо предустановить в зависимости EntityFrameworkCore.Tools
 
И прописать в консоле приложения команду ниже:

Scaffold-DbContext "server=localhost;port=3306;user=root;password=YourPassword;database=Your database" MySQL.Data.EntityFrameworkCore -o Models


Ссылка на видео: https://drive.google.com/file/d/1Rx4D3wG9jO68lYyf-kKWY6z4F6EWvdjo/view?usp=sharing
