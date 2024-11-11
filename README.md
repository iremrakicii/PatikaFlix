# PatikaFlix Uygulaması

Bu uygulama, kullanıcının dizi bilgilerini alarak, bu bilgileri listelemeye ve türüne göre "Komedi" dizilerini ayrı bir liste olarak göstermeye olanak tanır. Konsol tabanlı bir uygulama olarak C# dilinde geliştirilmiştir.

## İçindekiler
- [Projenin Yapısı](#projenin-yapısı)
- [Kullanılan Sınıflar](#kullanılan-sınıflar)
- [Nasıl Çalıştırılır?](#nasıl-çalıştırılır)
- [Özellikler](#özellikler)
- [Gereksinimler](#gereksinimler)

## Projenin Yapısı

Bu proje iki temel sınıf içerir:

- `Series`: Tüm dizi bilgilerini temsil eder.
- `ComedySeries`: Yalnızca komedi dizileri için oluşturulan bir sınıftır.

Program, kullanıcıdan dizinin adı, yapım yılı, türü, yayına başlama yılı, yönetmeni ve yayınlandığı platform gibi bilgileri alır. Ardından dizilerin listesini ekranda gösterir ve komedi türündeki dizileri ayrıca listeler.

## Kullanılan Sınıflar

### Series Sınıfı
`Series` sınıfı, dizilerin temel bilgilerini tutmak için kullanılır:
- `SeriesName` - Dizinin adı
- `PublicYear` - Yapım yılı
- `SeriesType` - Tür
- `ReleaseYear` - Yayınlanmaya başlama yılı
- `Director` - Yönetmen
- `ReleasePlatform` - Yayın platformu

#### Yapıcı Fonksiyon
- `Series(string _seriesName, int _publicYear, string _seriesType, int _releaseYear, string _director, string _releasePlatform)`: Yeni bir dizi oluşturur.

### ComedySeries Sınıfı
`ComedySeries` sınıfı, yalnızca komedi türündeki diziler için kullanılır. Bu sınıf, `Series` sınıfının bir alt kümesi olarak düşünülebilir ve komedi dizilerini `ToString` ile özel bir formatta gösterir.

#### Yapıcı Fonksiyon
- `_ComedySeries(string _arraysName, string _arrayType, string _director)`: Komedi dizisi için temel bilgileri alır.

## Nasıl Çalıştırılır?

1. Projeyi klonlayın veya indirin.
2. Projenizi IDE'nizde açın ve çalıştırın.
3. Program çalıştırıldığında, sizden kaç dizi eklemek istediğinizi soracaktır.
4. Dizi bilgilerini girdikten sonra, başka bir dizi eklemek isteyip istemediğiniz sorulacaktır.
5. Eklediğiniz tüm diziler ve komedi türündeki diziler ayrı ayrı listelenecektir.

## Özellikler

- Kullanıcı tarafından eklenen dizileri listeleme.
- Yalnızca "Komedi" türündeki dizileri filtreleme ve özel listeleme.
- Dizilerin yönetmen adına göre sıralanması.
