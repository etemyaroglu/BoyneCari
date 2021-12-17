# BoyneCari
Mongodb docker Çalışma Ortamının Hazırlanması
Docker mongo image kurulumu :  https://hub.docker.com/_/mongo linki üzerinden dokumanları takip ederek. MongoDB image kurabiliriz.
powershell üzerinden ilgili komutu kullanarak kurulumu gerçekleştirebiliriz : "docker pull mongo"
Docker mongo container oluşturmak :
docker run -d --name BoyneCariApp -p 27017:27017 mongo:latest
Uygulamanın kullanacağı database oluşturmak:  use BoyneCari
Ürün Tablosunu oluşturmak : db.createCollection("Product")
Kategori Tablosunu db.createCollection("Category")
Kategory tablosu schema ve dummy içerik oluşturma
db.Category.insertMany(
  {
     "_id": "7be25fac-6077-4f74-8cc7-dda4ab84030b",
    "Name": "Category 1",
    "Description": "Test",
  }  
)

Ürün Tablosu schema ve dummy içerik oluşturma :
db.Product.insertMany([
  {
    "id": "5be25fac-6077-4f74-8cc7-dda4ab84030b",
    "name": "Dummy",
    "description": "Lorem Ipsum",
    "categoryId": "7be25fac-6077-4f74-8cc7-dda4ab84030b",
    "price": 100,
    "currency": "TL"
  },
  {
    "id": "9be25fac-6077-4f74-8cc7-dda4ab84030b",
    "name": "Dummy 2",
    "description": "Lorem Ipsum",
    "categoryId": "7be25fac-6077-4f74-8cc7-dda4ab84030b",
    "price": 500,
    "currency": "TL"
  },
 
])
