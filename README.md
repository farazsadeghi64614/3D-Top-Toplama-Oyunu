# 3D Top Toplama Oyunu

## Proje Hakkında
Bu proje, Unity 6.0 kullanılarak geliştirilmiş 3D bir top toplama oyunudur. Oyuncu, oyun alanında hareket ederek yeşil ve kırmızı topları toplar ve gerekli puana ulaşarak seviyeleri tamamlar.

## Oyun Kontrolleri
- **W, A, S, D:** Oyuncuyu hareket ettirme
- **Yön tuşları:** Oyuncuyu hareket ettirme
- **R:** Oyun sona erdiğinde seviyeyi yeniden başlatma

## Puan Sistemi
- Yeşil top toplandığında oyuncu **10 puan** kazanır.
- Kırmızı topa temas edildiğinde oyuncu **5 puan** kaybeder.

## Seviyeler
Oyun üç seviyeden oluşmaktadır:
- **1. Seviye:** 30 puana ulaşılmalıdır.
- **2. Seviye:** 50 puana ulaşılmalıdır.
- **3. Seviye:** 70 puana ulaşılmalıdır.

Gerekli puana ulaşıldığında çıkış kapısı kullanılarak bir sonraki seviyeye geçilir. Son seviyenin tamamlanmasıyla oyun biter.

## Teknik Bilgiler
Oyun Unity 6.0 ve C# kullanılarak geliştirilmiştir. Oyuncunun hareketi Rigidbody ve AddForce ile sağlanmıştır. Toplarla etkileşim OnTriggerEnter yöntemiyle kontrol edilmiştir. Puan kontrolü if-else yapılarıyla gerçekleştirilmiş, seviyeler arasındaki geçişlerde SceneManager kullanılmıştır.

## Geliştirici
Faraz Sadeghfamiyan
