using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables; 
public class MaterialChanger : MonoBehaviour
{

    private Material originalMaterial;
    private Material selectedMaterial;

    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        
       
        if (originalMaterial == null && meshRenderer != null)
        {
            originalMaterial = meshRenderer.sharedMaterial;
        }
    }

    public void ChangeToSelectedMaterial()
    {
        if (meshRenderer != null && selectedMaterial != null)
        {
            meshRenderer.material = selectedMaterial;
        }
    }

   
    public void ChangeToOriginalMaterial()
    {
        if (meshRenderer != null && originalMaterial != null)
        {
            meshRenderer.material = originalMaterial;
        }
    }
}