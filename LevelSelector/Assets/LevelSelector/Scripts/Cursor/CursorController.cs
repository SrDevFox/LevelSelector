using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public Texture2D cursorTex;

    private void Start() => SetTexture();

    private void Update() => SetPosition();

    void SetTexture() => Cursor.SetCursor(cursorTex, Vector2.zero, CursorMode.Auto);
    

    void SetPosition()
    {
        Vector2 mousePos = Input.mousePosition;

        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        transform.position = Vector2.Lerp(transform.position, mousePos, 1f);
    }
}
