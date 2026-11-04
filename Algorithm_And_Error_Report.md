# Oyun Algoritması ve Hata Çözümü

## 1. Algoritmanın Açıklaması

Oyuncu oyuna birinci seviyede başlar. Oyuncu, WASD veya yön tuşlarını kullanarak oyun alanında hareket eder.

Oyun sırasında:
- Yeşil top toplandığında oyuncunun puanı 10 artar.
- Kırmızı topa temas edildiğinde oyuncunun puanı 5 azalır.
- Toplar toplandıktan sonra sahneden silinir.

Oyuncu gerekli puana ulaştığında çıkış kapısını kullanabilir.

Seviyelerin puan hedefleri:
- 1. Seviye: 30 puan
- 2. Seviye: 50 puan
- 3. Seviye: 70 puan

Oyuncu çıkış kapısından geçince sonraki seviyeye geçer. Üçüncü seviyeyi tamamladığında oyun biter ve kazanma mesajı gösterilir.

## 2. Karşılaşılan Hata ve Çözümü

Proje sırasında karşılaştığım sorunlardan biri, oyuncunun gerekli puana ulaştıktan sonra kırmızı topa temas etmesiyle puanının azalmasıydı. Bu durumda oyuncu çıkış kapısından geçemiyor ve oyunda ilerleyemiyordu.

Bu sorunu çözmek için puan kontrolü ve Game Over sistemi düzenlendi. Oyuncunun seviyesi geçmek için yeterli puanı olmadığında ekranda mesaj gösterildi. Ayrıca R tuşuyla seviyeyi yeniden başlatma özelliği eklendi.

## 3. Kullanılan Teknikler

- Rigidbody ve AddForce: Oyuncu hareketi
- OnTriggerEnter: Toplarla ve çıkış kapısıyla etkileşim
- CompareTag: Nesnelerin türünü kontrol etme
- Destroy: Topları sahneden silme
- if-else: Puan ve seviye kontrolleri
- SceneManager: Seviyeler arasında geçiş yapma

- <img width="1314" height="1844" alt="mermaid-diagram" src="https://github.com/user-attachments/assets/62a313f2-fb5d-493b-a357-3fac24ce43ef" />
