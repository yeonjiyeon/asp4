# asp4
session을 사용해 서버에 일정 시간 동안 글 등록 방지하기=========
FrmButtonClickOnce.aspx
===================================================

Global.asax 파일(전역 응용 프로그램 클래스)
Global.asax 파일은 전역 응용 프로그램 클래스라고 한다. 웹 프로젝트 루트에 위치하며 웹 사이트에 처음으로 사용자가 들어올 때, 
각각의 사용자가 들어올 때, 각각의 사용자가 나갈 때, 최종적으로 마지막 사용자가 나갈 때 등에 대한 정보를 얻어 
이에 대한 후속 조치 기능을 구현할 수 있는 이벤트를 제공
• Application_Start: 웹 프로젝트 가동 후 처음으로 사용자가 방문했을 때 발생한다.
• Application_End: 웹 프로젝트 가동 후 마지막 사용자가 나간 후 발생한다. 
		일반적으로 마지막 사용자의 최종 요청이 끝나고 20분 후에 발생한다.
• Session_Start: 각각의 사용자가 방문할 때 발생한다.
• Session_End: 각각의 사용자가 나가고 20분 후에 발생한다.
1. Application_Start 이벤트에서는 CurrentVisit라는 이름으로 Application 전역변수를 생성하고 0으로 초기화한다.
2. 각각의 사용자가 방문할 때마다 실행되는 Session_Start 이벤트에서는 이 CurrentVisit 변수의 값을 1씩 증가시켜 현재 접속자 수를 증가시킨다.
3. Session_End 이벤트에서는 각각의 사용자가 나간 후 카운트 변수를 1씩 감소시킨다.
4. 최종적으로 Application_End 이벤트에서 카운트 변수를 소멸시킨다.
실습_ 현재 접속자 수 표시 카운터 만들기=======================
DevCounter	Web Forms, MVC, Web API
FrmCounter.aspx
========================================

캐싱을 사용한 웹 페이지 성능 향상 기법
실습_ 캐싱을 이용한 웹 페이지 성능 향상=====================
DevCaching		Web Forms, MVC, Web API
FrmCachingWebUserControl.ascx --->사용자정의 컨트롤
FrmCaching.aspx
FrmCachingResponseCache.aspx
=================================================

환경 설정 파일인 Web.config
실습_ Web.Config 파일의 정보를 읽어 오는 클래스 사용하기=========
FrmConfiguration.aspx
===============================================


ADO.NET 데이터베이스 프로그래밍
System.Data.SqlClient 네임스페이스와 System.Data.OleDb 네임스페이스
• System.Data.SqlClient 네임스페이스: ASP.NET에서 SQL Server 데이터베이스에 대한 모든 처리를 담당하는 클래스들을 모아 놓은 네임스페이스다.
• System.Data.OleDb 네임스페이스: ASP.NET에서 SQL Server 데이터베이스를 포함하고 Microsoft Access 또는 Oracle 같은 데이터베이스 관련 클래스들을 묶어 놓은 네임스페이스다.
• System.Data.Odbc 네임스페이스: 텍스트 파일 또는 ODBC 호환 데이터 원본에 접근하기 위한 클래스들을 제공한다.
• System.Data.OracleClient 네임스페이스: Oracle 데이터베이스에 접근하기 위한 주요 클래스들을 제공한다.

Microsoft SQL Server

SQL Server LocalDB
SQL Server LocalDB 인스턴스 이름
• (localdb)\MSSQLLocalDB: SQL Server LocalDB의 기본 인스턴스 이름
• (localdb)\Projects13: SQL Server Data Tools(SSDT)에 의해서 생성된 인스턴스 이름
• (localdb)\v11.0: SQL Server 2012 LocalDB 기본 인스턴스 이름
cmd창에서 검색
C:\Users\user>sqllocaldb info

MSSQLLocalDB

SQL Server 개체 탐색기

데이터베이스 연결 문자열: Connection String
데이터베이스 연결 문자열의 필수 구성 요소 네 가지
• Server(Data Source): 데이터베이스 서버의 위치를 나타낸다. IP 주소 또는 도메인 정보를 입력한다.
• Database(DB, Initial Catalog): 데이터베이스의 이름을 지정한다.
• User ID(UID): 데이터베이스에 대한 권한에 있는 사용자 아이디를 입력한다.
• Password(PWD): 데이터베이스에 대한 권한이 있는 사용자 비밀번호를 입력한다.
System.Data.SqlClient를 위한 데이터베이스 연결 문자열 샘플
• Server=localhost; Initial Catalog=master; Integrated Security=true;
• Server=localhost; Database=master; User ID=UserId; Password=xyz;
• Server=tcp:ServerName\InstanceName,1433

닷넷에서 데이터베이스 처리 관련 주요 클래스
• Connection 클래스: 데이터베이스 연결 및 종료
• Command 클래스: 데이터베이스에 명령 실행
• DataReader 클래스: Select 구문의 실행 결괏값 받기
• DataSet 클래스: 메모리 상의 데이터베이스(Datatbase)로 Select와 같은 결괏값 저장
• DataAdapter 클래스: 명령어 전달 및 실행 후 값을 DataSet 클래스에게 전달
• DataTable 클래스: DataSet 안에 들어 있는 메모리 상의 테이블(Table)
• DataView 클래스: DataSet 안에 들어 있는 메모리 상의 뷰(View)

웹 앱 제작에 필요한 데이터베이스 처리 패턴 여섯 가지
• 입력(Write, Add, Create): 게시판 글쓰기, 상품 등록 등의 페이지에 적용, Insert 문 사용
• 출력(List, Get, Index): 게시판 리스트, 상품 진열 등의 페이지에 적용, Select 문 사용
• 상세(View, Detail): 게시판 상세보기, 상품 상세보기 등의 페이지에 적용, Select 문 사용
• 수정(Modify, Edit): 게시판 수정, 회원 정보 수정 등의 페이지에 적용, Update 문 사용
• 삭제(Delete, Remove): 게시판 삭제, 회원 탈퇴 등의 페이지에 적용, Delete 문 사용
• 검색(Search, Find): 게시판 검색, 상품 검색 등의 페이지에 적용, Select 문 사용
 실습_ DB 프로그래밍 학습을 위한 프로젝트 및 데이터베이스 구성==========
DevADONET
QL Server 개체 탐색기의 데이터베이스 폴더에서 마우스 오른쪽 버튼을 클릭해 새 데이터베이스 추가를 선택
데이터베이스 이름: DevADONET
Memos.sql
================================================

SqlConnection / OleDbConnection 클래스
데이터베이스 연결 및 종료
SqlConnection 클래스의 주요 속성 및 메서드
=====================================================
속성 또는 메서드		설명
-------------------------------------------------------------------------------------
ConnectionString		데이터베이스 연결 문자열을 설정해 SQL Server를 연결한다.
State			데이터베이스와의 연결 상태를 나타내는 ConnectionState 열거형을 반환한다.
			• ConnectionState.Open: 연결된 상태
			• ConnectionState.Closed: 닫혀 있는 상태
Open()			설정된 데이터베이스 연결 문자열을 사용해 데이터베이스를 연결한다.
Close()			현재 연결된 데이터베이스의 연결을 해제한다.
========================================================
실습_ SqlConnection 클래스를 사용해 SQL Server 연결하기================
FrmSqlConnection.aspx
============================================

 SqlCommand / OleDbCommand 클래스
 데이터베이스 명령 실행
SqlCommand 클래스:ASP.NET에서 SQL Server에 Create, Alter, Drop, Insert, Select, Update, Delete 같은 구문을 전달하고 실행
SqlCommand 클래스의 주요 속성 및 메서드는 다음 표와 같다.
============================================
속성 또는 메서드		이름
Connection		미리 설정되어 있는 커넥션 개체를 지정한다.
CommandText		실행할 SQL 문이나 SP(저장 프로시저) 문을 설정한다.
CommandType		CommandText 속성에서 지정한 구문의 형식을 CommandType 열거형으로 반환한다.
			• CommandType.Text: 일반적인 SQL 문
			• CommandType.StoredProcedure: 저장 프로시저 구문
			• CommandType.TableDirect: Access DB 전용(테이블명)
ExecuteNonQuery()		Select 문 이외의 구문을 실행하고자 할 때 주로 사용한다.
			• 테이블의 행에 영향을 미친 개수만큼 정숫값을 반환
ExecuteReader()		Select 문을 실행하고 그 결과를 SqlDataReader 개체로 반환한다.
			• 다중 값 반환: 레코드의 집합을 반환
ExecuteScalar()		Select 문을 실행하고 첫 번째 열(필드) 값을 반환한다.
			•단일 값 반환: 주로 집계 함수의 결과를 반환
====================================================
실습_ SqlCommand 클래스를 사용해 데이터베이스 명령어 실행=======
FrmSqlCommand.aspx
==============================================

SqlDataReader 클래스
 데이터베이스 명령 실행
========================================
속성 또는 메서드	설명
-----------------------------------------------------
FieldCount	Select 문의 실행 결과에서 필드(열)의 개수
HasRows		Select 문을 실행한 후 반환되는 레코드가 있으면 참
Read()		레코드가 있는 만큼 반복한다.
Close()		데이터 리더 개체를 닫는다.
GetXXX()		XXX 형식으로 필드(컬럼) 값을 반환한다.
====================================================
실습_ SqlDataReader 클래스로 데이터를 받아 출력하기==============
FrmSqlDataReader.aspx
===============================================
* Identity 컬럼
참고로 Num 필드는 Identity 속성으로 자동 증가값으로 설정되어 있지만, 
SQL Server의 Identity는 반드시 그 다음 숫자값이 입력된다는 보증은 없다. 
옆의 그림처럼 번호가 1,000단위로 증가할 수도 있다.

SqlDataAdapter 클래스와 DataSet 클래스
DataSet 클래스 개요
앞서 살펴본 DataSet 클래스는 ‘메모리의 데이터베이스’라고 정의
SqlDataAdapter 클래스
DataSet 클래스가 Select 문의 실행 결과를 담아 놓는 그릇 역할을 한다면 SqlDataAdapter 클래스는 
Select 문을 실행시키고 실행된 결괏값을 가져다가 DataSet 개체에게 채워주는 중간 매개체 역할을 한다. 
즉, DataSet 클래스와 SqlDataAdapter 클래스는 뗄래야 뗄 수 없는 관계
실습_ SqlDataAdapter와 DataSet 클래스로 데이터 출력하기============
FrmSqlDataAdapter.aspx
===============================================


CRUD란?
웹 응용 프로그램 제작의 첫 번째 패턴 익히기: 입력
데이터 입력(Write/Add/Insert) 패턴
• 게시판 글쓰기
• 회원 가입
• 일정 등록
• 상품 등록
실습_ Memos 테이블에 데이터 입력하기=============
FrmMemoWrite.aspx
/Models/Memo.cs클래스
===============================================

웹 응용 프로그램 제작의 두 번째 패턴 익히기: 출력
출력(List/Get/Select) 패턴
• 게시판 리스트
• 회원 리스트
• 상품 리스트

실습_ Memos 테이블의 모든 데이터 출력하기=============
FrmMemoList.aspx
===============================================

웹 응용 프로그램 제작의 세 번째 패턴 익히기: 상세
상세(View/Content/Detail) 패턴
• 게시판 내용 보기
• 회원 정보 보기
• 상품 상세보기
실습_ Memos 테이블에서 단일 데이터 출력============
FrmMemoView.aspx
===============================================

웹 응용 프로그램 제작의 네 번째 패턴 익히기: 수정
수정(Modify/Edit/Update) 패턴
• 게시판 글 수정
• 회원 정보 수정
• 상품 수정
실습_ Memos 테이블의 데이터 수정하기====================
FrmMemoModify.aspx
===============================================

웹 응용 프로그램 제작의 다섯 번째 패턴 익히기: 삭제
삭제(Delete/Remove) 패턴
• 게시판 글 삭제
• 회원 탈퇴
• 상품 제거
실습_ Memos 테이블에서 데이터 삭제하기=========
FrmMemoDelete.aspx
===============================================

웹 응용 프로그램 제작의 여섯 번째 패턴 익히기: 검색
13.12.1 검색(Search/Find) 패턴
• 게시판 글 검색
• 상품 검색
• 데이터 검색
• 페이징(Paging) 및 정렬(Sorting)
실습_ Memos 테이블에서 데이터 검색하기=====================
FrmMemoSearch.aspx
===============================================
