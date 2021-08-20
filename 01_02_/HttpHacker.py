import sys
import requests
import lxml
import html
from bs4 import BeautifulSoup

id = sys.argv[1]
passwd = sys.argv[2]

headers = {
    'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.114 Safari/537.36',
    }
formdata = {
    'SCH_NO': 'SC',
    'Time': '',
    'LEVEL': '0',
    'REMOTE_HOST': '203.204.53.38',
    #'txtS_NO': '910082',
    #'txtPerno': 'A131207683',
    #'txtS_NO': '910180',
    #'txtPerno': 'M223214443',
    'txtS_NO': str(id),
    'txtPerno': str(passwd),
    'mess1': '%BE%C7%B8%B9%A1G%BF%E9%A4J%BE%C7%A5%CD%BE%C7%B8%B9%0D%0A%0D%0A%B1K%BDX%A1G%BF%E9%A4J%A8%AD%A4%C0%C3%D2%B2%CE%A4%40%BDs%B8%B9%28%A7t%A4j%BCg%AD%5E%A4%E5%A6r%A5%C0%A1%CF9%AD%D3%BC%C6%A6r%A1A%A6%4010%BDX%29%0D%0A%0D%0A%ADY%A8%AD%A4%C0%C3%D2%A6r%B8%B9%A5%BF%BDT%A6%D3%B5L%AAk%A8%CF%A5%CE%A1A%A6V%B5%F9%A5U%B2%D5%ACd%B8%DF%A1C',
    'mess2': ''
    }
url ='http://203.68.25.72/csn/Reg_Stu.ASP'
session = requests.Session()
session.post( url,  headers = headers,  data = formdata)

response = session.get('http://203.68.25.72/csn/stu_info.asp',headers = headers)# 登入後，獲取另一個網頁中的內容

response.encoding = 'big5'

soup = BeautifulSoup(response.text,"lxml")
titles = soup.body.text
html.unescape(titles)
pos=titles.find('error')
if (pos >= 0):   # 有找到

    id  = ""
    passwd = ""
    print ("None")

else:   # 沒有找到
    
    id  = ""
    passwd = ""
    print(response.text)