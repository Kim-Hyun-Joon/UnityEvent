using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    /// 이처럼 하드하게 알고 있어야 얘네들의 기능을 발동시킬 수 있다
    //public UIManager UIManager;
    //public AchivementSystem achivementSystem;
    //public GameManager gameManager;
    /// 플레이어의 죽음과 관련된 스크립트가 늘어날수록
    /// 계속해서 선언을 통해 사용하는 것은 지저분한 방법이다
    /// 

    public UnityEvent onPlayerDead;

    private void Dead() {

        //UIManager.OnPlayerDead();
        //achivementSystem.UnLockAchivement("뉴턴의 법칙");
        //gameManager.OnPlayerDead();

        onPlayerDead.Invoke();

        Debug.Log("죽었다");
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other) {
        Dead();
    }
}
