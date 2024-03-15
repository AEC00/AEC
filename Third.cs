using System.Collections.Generic;
using UnityEngine;
public class ColorChanger : MonoBehaviour
{
// List of colors
public List<Color> colors;
private int currentColorIndex = 0; 
void Update()
{
if (Input.GetMouseButtonDown(0)) 
{
Vector2 mousePosition =
Camera.main.ScreenToWorldPoint(Input.mousePosition);
RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero); 
if (hit.collider != null && hit.transform == this.transform) 
{
// Change to the next color in the list
currentColorIndex = (currentColorIndex + 1) % colors.Count;
GetComponent<SpriteRenderer>().color = colors[currentColorIndex];
}
}
}
}
