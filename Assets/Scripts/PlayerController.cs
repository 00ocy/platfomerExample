using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float moveCooltime; // �̵� Ű�� �������� �Ҽ��� ������ ���� ���Ұ���(Ƚ��), (moveSpedd * moveColltime = �������� ���̶�� ���� ��)
    public float moveSpeed; // move Cooltime 1ȸ�� ��ŭ�� ���� ���Ұ�����(��)
    // ���� ũ�� �ϰ� Colltime�� ��� �ָ� *����*�� ������
    // ���� �۰� �ϰ� Colltime�� ª�� �ָ� *����*�� ������
    public Rigidbody2D rb;
    private bool isMoving = false;

    private void Start()
    {
        // Rigidbody2D ������Ʈ ��������
        rb = GetComponent<Rigidbody2D>();
    }

    public void MoveLeft()
    {
        if (!isMoving)
        {
            StartCoroutine(MoveCoroutine(Vector2.left));
        }
    }

    public void MoveRight()
    {
        if (!isMoving)
        {
            StartCoroutine(MoveCoroutine(Vector2.right));
        }
    }

    IEnumerator MoveCoroutine(Vector2 direction)
    {
        isMoving = true;
        rb.AddForce(direction * moveSpeed, ForceMode2D.Force);
        yield return new WaitForSeconds(moveCooltime); // ���� ������ ������ �ð�
        isMoving = false;
    }
}
