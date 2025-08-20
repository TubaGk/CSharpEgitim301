# CSharpEgitim301

# 🗺️ EF Travel Statistics Project

Bu proje, **C# Windows Forms** ile geliştirilmiş bir seyahat istatistikleri uygulamasıdır.  
**Entity Framework (DbFirst yaklaşımı)** kullanılarak veritabanındaki **Location** ve **Guide** tablolarından bilgiler çekilmiştir.  

## 📊 Özellikler
- Toplam lokasyon sayısını görüntüleme  
- Tüm lokasyonların toplam kapasitesini hesaplama  
- Rehber (Guide) sayısını listeleme  
- Ortalama kapasite ve ortalama tur fiyatını hesaplama  
- Son eklenen ülke adını bulma  
- Belirli bir tur (örn. Kapadokya) için kapasite bilgisini alma  
- Türkiye’deki turların ortalama kapasitesini gösterme  
- Roma turunu yöneten rehberin adını bulma  
- En yüksek kapasiteye sahip turu bulma  
- En pahalı turu bulma  
- Belirli bir rehberin (örn. Tuba Gök) yönettiği tur sayısını hesaplama  

## 🗄️ Kullanılan Veritabanı

### Location Tablosu
| LocationId | City       | Country   | Capacity | Price   | DayNight     | GuideId |
|------------|-----------|-----------|----------|---------|--------------|---------|
| 1          | Romaa     | İtalya    | 15       | 28000   | 1 Gece 2 Gün | 6       |
| 3          | Kapadokya | Türkiye   | 50       | 40000   | 5 Gece 4 Gün | 4       |
| 4          | Paris     | Fransa    | 20       | 21000   | 6 Gece 7 Gün | 6       |
| 5          | Ege Turu  | Türkiye   | 20       | 15000   | 5 Gece 6 Gün | 1       |
| 6          | İstanbul  | Türkiye   | 40       | 50000   | 3 Gece 2 Gün | 6       |
| 1002       | Sofya     | Bulgaristan| 70      | 15000   | 1 Gece 2 Gün | 3       |
| 1003       | Milano    | İtalya    | 20       | 58000   | 2 Gece 3 Gün | 1       |

### Guide Tablosu
| GuideId | GuideName | GuideSurname |
|---------|-----------|--------------|
| 1       | Alii      | Yılmaz       |
| 2       | Ayşe      | Çınar        |
| 3       | Hakan     | Kaya         |
| 4       | Neriman   | Öz           |
| 6       | Tuba      | Gök          |

## 🖥️ Uygulama Ekranı
Aşağıda uygulamanın ekran görüntüsü yer almaktadır:  

![FrmStatistics Ekran Görüntüsü](https://github.com/TubaGk/CSharpEgitim301/blob/master/CSharpEgitim301.EFProject/images/frmStatistics.jpg)


## ⚙️ Kullanılan Teknolojiler
- C# (.NET Framework, Windows Forms)
- Entity Framework (DbFirst yaklaşımı)
- MSSQL Server (Veritabanı yönetimi)

---
