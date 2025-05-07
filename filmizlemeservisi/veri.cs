using System.Collections.Generic;

namespace FilmIzlemeSistemi
{
    public static class filmveri
    {
        // Film isimleri ve içerikleri
        public static List<string> filmIsimleri = new List<string>
        {
            "Film 1: Kayıp Zaman",
            "Film 2: Karanlıkta Hayat",
            "Film 3: Geceye Yolculuk",
            "Film 4: Sonsuz Sınır"
        };

        public static Dictionary<string, string> filmIcerikleri = new Dictionary<string, string>
        {
            {
                "Film 1: Kayıp Zaman",
                "Film 1 İçeriği: Kayıp Zaman, bir adamın geçmişiyle yüzleşmesini konu alır. " +
                "Başlangıçta, baş karakterin hayatı sıradan bir şekilde geçmektedir. Ancak, bir gün eski bir hatıra ona hayatının kaybolan yıllarını hatırlatır. " +
                "\n\nBölüm 1: Adamın geçmişe dönme kararı ve eski hatıralarla yüzleşmesi anlatılmaktadır. " +
                "Bölüm 2: Geçmişindeki kaybolan zamanın, hayatındaki anlamını keşfetmesi. Bu, onun gelecekteki kararlarını etkiler. " +
                "\n\nBölüm 3: Kahraman, geçmişiyle barıştıktan sonra, hayatına daha güçlü bir şekilde devam etmeyi öğrenir."
            },
            {
                "Film 2: Karanlıkta Hayat",
                "Film 2 İçeriği: Karanlıkta Hayat, bir grup insanın gözlerini kaybetmelerinin ardından hayatta kalma mücadelesini konu alır. " +
                "Kahramanımız, bir kazanın ardından görme yetisini kaybeder ve karanlık bir dünyada hayatta kalmak için mücadele etmeye başlar. " +
                "Bölüm 1: Görme yetisini kaybeden ana karakterin içsel yolculuğu ve hayatta kalma çabaları anlatılmaktadır. " +
                "\n\nBölüm 2: Gözleri görmeyen bir grup insanın birlikte bir arada yaşaması ve hayatta kalma yöntemlerini öğrenmeleri. " +
                "Bölüm 3: Karakterler, karanlık dünyada umut ve güven arayışında, birbirlerine yardım ederek zorlukların üstesinden gelirler."
            },
            {
                "Film 3: Geceye Yolculuk",
                "Film 3 İçeriği: Geceye Yolculuk, bir grup insanın sıradan bir geceyi geçirmesini konu alır, ancak gece ilerledikçe olaylar hızla kontrolden çıkar. " +
                "Kasaba halkı, geceyi bir arada geçirebilmek için meydanda toplanır. Ancak, gece geçtikçe, karanlık bir sır ortaya çıkar. " +
                "\n\nBölüm 1: Geceyi geçirmeye karar veren grup üyeleri kasabaya gelir. Sadece bir kaç saatlik bir süre içinde her şey değişir. " +
                "Bölüm 2: Yabancı bir adam kasabaya gelir ve insanlar, geceyi birlikte geçirmek için onunla zaman geçirmeye başlarlar. " +
                "\n\nBölüm 3: Gece ilerledikçe, yabancı adamın geçmişi bir tehdit oluşturur. Kasaba halkı, ortaya çıkan gizemi çözmek için gece boyunca savaşmak zorunda kalır."
            },
            {
                "Film 4: Sonsuz Sınır",
                "Film 4 İçeriği: Sonsuz Sınır, bir grup bilim insanının zamanın ve uzayın sınırlarını keşfetmesini konu alır. " +
                "Başlangıçta, bilim insanları geleceği değiştirmek için devrimsel bir deney yaparlar. Ancak, deneylerin beklenmedik sonuçları, onların geçmişe gitmelerine neden olur. " +
                "\n\nBölüm 1: Zamanı kontrol etmeye çalışan bir grup bilim insanının deneyleri ve bu deneylerin dünya üzerindeki etkileri. " +
                "\n\nBölüm 2: Bilim insanları zamanın sınırlarını aşmaya karar verirler, ancak her adımda karşılaştıkları tehlikeler onları evrenin derinliklerine doğru çeker. " +
                "\n\nBölüm 3: Kahramanlar, zamanı ve evreni korumak için mücadele ederken, sonsuz sınırları aşmanın tehlikelerini anlamaya başlarlar."
            }
        };
    }
}
