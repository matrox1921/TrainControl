# TrainControl
산학협력 프로젝트 (세화)를 위한 C#/.NET 기술스택 사전학습


환경설정

==============visual studio 기본 세팅(C#, .NET)=================
1. visual studio 다운로드
https://visualstudio.microsoft.com/ko/vs/community
1-1. 설치시 ".NET 데스크톱 개발" 체크
1-2. 로그인할때 깃허브 계정으로 로그인하기

2. 새 프로젝트 만들기
→ WPF Application

3. .NET 8 버전 선택


==================Git 설치====================
https://git-scm.com/install/windows
다음 계속 누르다가 Adjusting your PATH environment에서 Git from the command line and also from 3rd-party software 체크 됐는지 확인

다운 끝나면 powershell 열어서 git --version 으로 버전 체크. ( 잘 됐으면 git version 2.54.0.windows.1 같이 나옴)

visual studio 재부팅 후 터미널에서 git --version 명령어 되는지 체크


=================깃허브 연동====================
기본 개념
clone : 원격 저장소를 내 컴퓨터에 처음 복사
pull : 원격 저장소 최신 변경사항 받아오기
push : 내 변경사항 GitHub에 올리기

================1) 새 프로젝트 생성 후 깃허브에서 pull하고 싶은 경우===================
1. 상단 git 클릭
2. 리포지토리 복제 (Clone) 클릭
3. https://github.com/아이디/프로젝트명.git 입력

아니면 터미널에서 아래 명령어 입력해도됨
git clone https://github.com/아이디/프로젝트명.git

-> clone은 최초 1회만 하면 되고, 그 이후는 2번 명령어 따라하면 된다.

================2) 이미 clone된 프로젝트 최신화===================
터미널에 입력
git pull

================3) 내 프로젝트를 기반으로 새 리포지토리를 만들고 push하고 싶은 경우===================
상단 메뉴 - git - git 리포지토리 만들기 - github - 만들기 및 푸시

================4) 내 프로젝트를 이미 존재하는 리포지토리에 push하고 싶은 경우===================
상단 메뉴 - git - git 리포지토리 만들기 - 기존 원격 - URL 입력 후 만들기 및 푸시


===================깃 터미널 흐름=====================
git pull
(작업)
git add .
git commit -m "작업 내용"
git push

현재 상태 보는 명령어
git status

커밋 메세지는 기능: 내용 이런식으로 쓰면 좋음
feat: 실시간 시계 추가
fix: 버튼 클릭 오류 수정
ui: 메인 화면 디자인 변경

===================conflict 나면?=====================


===================branch 바꾸는 법===================
git branch -m master main
git push -u origin main
이러면 master에서 main으로 바뀜
중간에 오류나면
git pull origin main --allow-unrelated-histories
vim 나오면 esc 후 :wq 입력하고 엔터 후에 다시
git push -u origin main
시도
