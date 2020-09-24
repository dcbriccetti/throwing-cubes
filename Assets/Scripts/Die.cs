using System.Linq;
using UnityEngine;

public class Die : MonoBehaviour {
    public Texture[] texture;
    private Rigidbody rb;

    void Start() {
        TextureOneFace();
        Throw();
    }

    private void Throw() {
        rb = transform.GetComponent<Rigidbody>();
        float R() => Random.Range(-15000, 15000);
        transform.Translate(Random.Range(-15f, 15f), Random.Range(-3f, 3f), Random.Range(-3f, 3f));
        rb.velocity = new Vector3(Random.Range(-1f, 1f), Random.Range(-7f, -3f), Random.Range(30f, 50f));
        rb.angularVelocity = new Vector3(R(), R(), R());
    }

    private void TextureOneFace() {
        var mr = transform.GetComponent<MeshRenderer>();
        var facesMaterials = mr.materials.Where(mat => mat.name != "Base (Instance)").ToArray();
        var selMat = facesMaterials[Random.Range(0, facesMaterials.Count())];
        selMat.mainTexture = texture[0];
    }
}
