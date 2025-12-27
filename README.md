🧠 WinForms + ML.NET Binary Classification Uygulaması

Bu proje, C# WinForms ve ML.NET kullanılarak geliştirilmiş bir
ikili sınıflandırma (Binary Classification) uygulamasıdır.

Uygulama; kullanıcının gelir, kredi skoru ve iş durumu bilgilerine göre
kredi alıp alamayacağını tahmin eder.

Bu çalışma, makine öğrenmesinde classification konusunu pratik bir masaüstü uygulaması üzerinden göstermek amacıyla hazırlanmıştır.

🎯**PROJENİN AMACI**

Bu projenin temel amaçları:

Binary Classification (ikili sınıflandırma) mantığını kavramak

ML.NET kullanarak basit bir makine öğrenmesi modeli oluşturmak

WinForms arayüzü ile kullanıcıdan veri alarak tahmin yapmak

Makine öğrenmesini masaüstü uygulamaya entegre etmek

🛠 KULLANILAN TEKNOLOJİLER

C#

WinForms

.NET Framework

ML.NET

Binary Classification

SdcaLogisticRegression / FastTree

📁 Proje Yapısı

📦 CreditClassificationApp
├── Form1.cs
├── Form1.Designer.cs
├── CreditData.cs
├── CreditPrediction.cs
├── Program.cs
├── data.csv
└── README.md

📄 Veri Seti (data.csv)

Model, aşağıdaki alanları içeren bir CSV dosyası ile eğitilmiştir:

Alan Adı	Açıklama
Income	Kişinin aylık geliri
CreditScore	Kredi skoru
HasJob	İş durumu (1 = Var, 0 = Yok)
Label	Sonuç (1 = Kredi Verilir, 0 = Kredi Verilmez)

Örnek veri:

Income,CreditScore,HasJob,Label
9000,720,1,1
8500,700,1,1
10000,780,1,1
4000,500,0,0
3000,450,0,0
2000,420,0,0

🧠 MOFDEL EĞİTİMİ

Uygulamada Binary Classification yöntemi kullanılmıştır.
Model aşağıdaki özellikleri kullanarak eğitilir:

Gelir

Kredi Skoru

İş Durumu


🖥 UYGULAMA KULLANIMI

1. Uygulama çalıştırılır

2. Modeli Eğit butonuna basılır

Kullanıcı:

Gelir

Kredi Skoru

İş Durumu
bilgilerini girer

3. Tahmin Et butonuna basılır

4. Sonuç ekranda gösterilir:

KREDİ VERİLİR

KREDİ VERİLMEZ

🖼 EKRAN GÖRÜNTÜSÜ


<img width="788" height="481" alt="Ekran görüntüsü 2025-12-27 205257" src="https://github.com/user-attachments/assets/feaca6eb-9d66-45c8-951a-acfbc6221e6b" />



Bu proje bir Binary Classification (İkili Sınıflandırma) problemidir.

1 → Kredi Verilir

0 → Kredi Verilmez

Bu nedenle regresyon değil, sınıflandırma problemidir.

🔚 Sonuç

Bu proje, ML.NET kullanılarak geliştirilmiş temel seviyede bir
ikili sınıflandırma uygulamasıdır.

Makine öğrenmesi algoritmalarının WinForms ile nasıl entegre edileceğini
göstermek amacıyla hazırlanmıştır.

👩‍💻 Geliştirici: Zehra
🎓 Bölüm: Yazılım Mühendisliği

