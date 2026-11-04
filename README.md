# 3D Top Toplama Oyunu

**Öğrenci Adı Soyadı:** Faraz Sadeghfamiyan  
**Öğrenci Numarası:** 2402020042  
**Ders:** Oyun İçin Kod Yazımı I

## Oyun Hakkında
Bu oyun Unity 6.0 ve C# kullanılarak geliştirilmiş üç seviyeli bir 3D top toplama oyunudur. Oyuncu, oyun alanında hareket ederek yeşil ve kırmızı topları toplar ve seviyeleri tamamlamaya çalışır.

## Kontroller
- WASD veya yön tuşları: Hareket
- R: Game Over durumunda seviyeyi yeniden başlatma

## Puan Sistemi
- Yeşil top: +10 puan
- Kırmızı top: -5 puan

**Seviye hedefleri:**
- Level 1: 30 puan
- Level 2: 50 puan
- Level 3: 70 puan

## C# Scriptleri
- **PlayerController:** Oyuncu hareketini, puan sistemini, nesnelerle etkileşimi ve seviye geçişlerini kontrol eder.
- **CheckerboardGenerator:** Oyun alanındaki zemin düzenini oluşturur.

## Algoritma
Oyuncu toplara temas ettiğinde puanı güncellenir. Hedef puana ulaştığında çıkış kapısından geçerek sonraki seviyeye ilerler.

## Hata ve Çözümü
Puan azaldığında oyuncunun çıkış kapısından geçememesi sorunu için Game Over ve R tuşuyla yeniden başlatma sistemi düzenlendi.

## Oyunu Çalıştırma
Projeyi Unity 6.0 ile açın ve Level1 sahnesini çalıştırın.

## Oynanış Videosu
[Üç Seviyeli Oynanış Videosunu İzle](https://drive.google.com/file/d/1B3Fp4JtWhepHUk4C3bidx72KsLAyy88K/view?usp=sharing)
