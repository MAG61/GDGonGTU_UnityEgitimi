using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 10f; // Uygulayaca��m�z kuvvet miktar�n�n d��ar�dan(Inspector penceresi de dahil) da eri�ilebilir olmas� i�in public bir float tan�ml�yoruz.
                                  // = 10f k�sm� bu float de�i�kenin ba�lang�� de�eri oluyor. E�er sonradan bir d�zenleme yapmazsak 10 olarak kalacak.
                                  // Fakat biz Unity aray�z�nde Inspector penceresinden bu de�eri daha sonra elle girece�iz.

                           // Rigidbody2D: Objemizin fizik sisteminden etkilenmesini sa�layan component.
    public Rigidbody2D rb; // Daha sonra �zerinde oynamalar yapmak i�in bir Rigidbod2D de�i�ken tan�ml�yoruz.
                           // �u anda herhangi bir atama yap�lmad��� i�in i�i bo�(null)

    void Start() // Start fonksiyonu oyunu ba�latt���m�zda Awake fonksiyonunun ard�ndan sadece bir kere �al���r.
    {
        rb = GetComponent<Rigidbody2D>(); // Yukar�da tan�mlad���m�z rb de�i�kenine bir atama yap�yoruz. 
                                          // GetComponent fonksiyonunu kullanarak bu scriptin bulundu�u objenin componentlerine eri�iyoruz.
    }

    void Update() // Update oyun ba�lad�ktan sonra oyunun her karesinde birer kere �al���r.
    {
        Vector2 jumpVector = new Vector2(0 ,jumpForce); // Rigidbody.AddForce fonksiyonu Vector2 tipinde bir parametre istedi�i i�in tan�ml�yoruz.

        if(Input.GetKeyDown(KeyCode.Space)) // GetKeyDown ile tu�a bas�lma an�n� alg�l�yoruz. (GetKeyDown: Tu�un ilk bas�lma an�, GetKey: Bas�l� tutarken, GetKeyUp: Tu� b�rak�ld��� an)
        {
            rb.AddForce(jumpVector); // Start fonksiyonunda atamas� yap�lm�� olan Rigidbody de�i�kenimizden AddForce fonksiyonunu �a��r�yoruz.
                                     // AddForce obje �zerine belli bir kuvvet uygulamam�z� sa�l�yor. Kuvvetin b�y�kl���n� Vector2 tipinde bir parametre ile belirliyoruz.
        }

        Debug.Log(rb.linearVelocity); // Debug.Log ile Unity aray�z�ndeki geli�tirici konsol ekran�na istedi�imiz �eyi(Bu �rnek i�in ku�un h�z vekt�r�) yazd�r�yoruz.

    }
}
