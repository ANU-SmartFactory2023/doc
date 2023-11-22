
import http.client , urllib.parse
import json
import requests

# 이름과 비밀번호 속성을 가진 TestModel 클래스 정의
class TestModel:
    name: str
    password: str

# TestModel 인스턴스 생성하고 속성 설정
testModel = TestModel()
testModel.name = "test"
testModel.password = "1234"


# testModel 속성을 JSON 문자열로 변환
params = json.dumps(testModel.__dict__)
headers = {"Content-type": "application/json", "Accept": "*/*"}

# requests 모듈을 사용하여 POST 요청 보내기
try:
    response = requests.post('http://localhost:5294/api/values/value3', data=params, headers=headers)
    response.raise_for_status()  # HTTP 오류 확인
    print("응답:", response.text)
except requests.exceptions.RequestException as e:
    print(f"RequestException: {e}")






"""
r = requests.post( host_url + "/api/values/value3", json=form_data ).text #ok
print( "value3 : " + r )


print( "=============================================" )


r = requests.post( host_url + "/api/values/value1", json='{"name":"test","password":"1234"}' ).text #ok
print( "value1 : " + r )


print( "=============================================" )


class TestModel :
    name:str
    password:str
    
testModel = TestModel()
testModel.name = "test"
testModel.password = "1234"

r = requests.post( host_url + "/api/values/value3", json=testModel.__dict__ ).text #ok
print( "value3 : " + r )

"""