using UnityEngine;

public class ProceduralMesh : MonoBehaviour
{
    [SerializeField] private Material _material;

    private Mesh _mesh;
    private MeshFilter _meshFilter;
    private MeshRenderer _meshRenderer;

    private void Start()
    {
        _meshFilter = gameObject.AddComponent<MeshFilter>();
        _meshRenderer = gameObject.AddComponent<MeshRenderer>();

        _mesh = new Mesh();

        _meshFilter.mesh = _mesh;
    }
}
