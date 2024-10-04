/*C#’da veri türleri temel olarak değer (value) ve referans (reference) olmak üzere ikiye ayrılır.
 * Değer türleri (int, float, double, uint, struct vb) belleğin stack bölgesinde tutulur.
 * Referans türleri (class, object, array, interface, delegate, string vb) belleğin heap bölgesinde tutulur.
 * Metotlara veya metotlardan değer tiplerin referanslarını iletmek veya döndürmek için kullanılır. Diğer bir deyişle, referans yoluyla iletilen bir değerde yapılan herhangi bir değişikliğin, yalnızca taşıdığı değeri değil, adresteki (referans) değeriğinide değiştirdiğiniz için bu değişikliği yansıtacağı anlamına gelir. 
 * ref  -> refrence : referans
 */

int x = 10;
int y = 20;
Console.WriteLine("{0},{1}",x,y);
Degistir(x,y);
Console.WriteLine("{0},{1}", x,y);
Console.ReadKey(); //Kullanıcı tarafından basılan bir sonraki karakteri veya işlev tuşunu alır. Basılan tuş konsol penceresinde görüntülenir.


static void Degistir(int a, int b)
{
    int gecici = a;
    a = b;
    Console.WriteLine("{0},{1}",a,b);
}
