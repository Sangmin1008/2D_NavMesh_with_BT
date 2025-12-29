# 2D NavMesh with Behavior Tree (Unity)

## 프로젝트 소개

이 프로젝트는 **Unity 2D 환경**에서 **NavMesh 기반 이동**과 **Behavior Tree(BT)** 를 결합하여 적 캐릭터의 행동 상태를 구현한 샘플 프로젝트입니다.

적은 상황에 따라 순찰, 추적, 공격 등의 행동을 전환하며, Behavior Tree를 통해 상태 전이를 구조적으로 관리합니다.

---

## 주요 기능

* **2D NavMesh 이동**

  * Unity NavMesh를 2D 환경에 맞게 적용
  * 장애물을 고려한 경로 탐색 및 이동

* **Behavior Tree 기반 AI**

  * Selector / Sequence 구조를 활용한 행동 설계
  * 상태 전이를 코드가 아닌 트리 구조로 관리
  * 확장성과 가독성을 고려한 AI 구조

* **적 행동 상태 예시**

  * Idle
  * Patrol
  * Wander
  * Chase
  * Attack

---

## 사용 기술

* **Engine**: Unity
* **Language**: C#
* **AI 구조**: Behavior Tree
* **Pathfinding**: Unity NavMesh (2D 활용)

---

## 목적 및 학습 포인트

* Behavior Tree를 활용한 **AI 상태 관리 방식 이해**
* 2D 환경에서의 **NavMesh 활용 방법 학습**
* FSM 대비 Behavior Tree의 장점 체험

---

## 참고

* **2D NavMesh**: NavMeshPlus

  * [https://github.com/h8man/NavMeshPlus](https://github.com/h8man/NavMeshPlus)
* **Behavior Tree 강의**:

  * YouTube – *[유니티6] Behavior Tree를 이용한 AI 구현*
  * [https://www.youtube.com/watch?v=ZbWbxlCQ6cA](https://www.youtube.com/watch?v=ZbWbxlCQ6cA)

---

## ✍️ Author

* **Sangmin Park**
* GitHub: [https://github.com/Sangmin1008](https://github.com/Sangmin1008)
