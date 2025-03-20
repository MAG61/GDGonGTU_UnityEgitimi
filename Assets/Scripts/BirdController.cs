using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 10f; // Uygulayacaðýmýz kuvvet miktarýnýn dýþarýdan(Inspector penceresi de dahil) da eriþilebilir olmasý için public bir float tanýmlýyoruz.
                                  // = 10f kýsmý bu float deðiþkenin baþlangýç deðeri oluyor. Eðer sonradan bir düzenleme yapmazsak 10 olarak kalacak.
                                  // Fakat biz Unity arayüzünde Inspector penceresinden bu deðeri daha sonra elle gireceðiz.

                           // Rigidbody2D: Objemizin fizik sisteminden etkilenmesini saðlayan component.
    public Rigidbody2D rb; // Daha sonra üzerinde oynamalar yapmak için bir Rigidbod2D deðiþken tanýmlýyoruz.
                           // Þu anda herhangi bir atama yapýlmadýðý için içi boþ(null)

    void Start() // Start fonksiyonu oyunu baþlattýðýmýzda Awake fonksiyonunun ardýndan sadece bir kere çalýþýr.
    {
        rb = GetComponent<Rigidbody2D>(); // Yukarýda tanýmladýðýmýz rb deðiþkenine bir atama yapýyoruz. 
                                          // GetComponent fonksiyonunu kullanarak bu scriptin bulunduðu objenin componentlerine eriþiyoruz.
    }

    void Update() // Update oyun baþladýktan sonra oyunun her karesinde birer kere çalýþýr.
    {
        Vector2 jumpVector = new Vector2(0 ,jumpForce); // Rigidbody.AddForce fonksiyonu Vector2 tipinde bir parametre istediði için tanýmlýyoruz.

        if(Input.GetKeyDown(KeyCode.Space)) // GetKeyDown ile tuþa basýlma anýný algýlýyoruz. (GetKeyDown: Tuþun ilk basýlma aný, GetKey: Basýlý tutarken, GetKeyUp: Tuþ býrakýldýðý an)
        {
            rb.AddForce(jumpVector); // Start fonksiyonunda atamasý yapýlmýþ olan Rigidbody deðiþkenimizden AddForce fonksiyonunu çaðýrýyoruz.
                                     // AddForce obje üzerine belli bir kuvvet uygulamamýzý saðlýyor. Kuvvetin büyüklüðünü Vector2 tipinde bir parametre ile belirliyoruz.
        }

        Debug.Log(rb.linearVelocity); // Debug.Log ile Unity arayüzündeki geliþtirici konsol ekranýna istediðimiz þeyi(Bu örnek için kuþun hýz vektörü) yazdýrýyoruz.

    }
}
