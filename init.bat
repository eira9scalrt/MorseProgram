@rem ---C#ランタイムのパスを通す
path = C:\Windows\Microsoft.NET\Framework64\v4.0.30319
set str=%~nx1
set exefile=%str:cs=exe%

@rem --- 引数なしでバッチファイルを実行したとき
@if "%1"=="" (
start cmd \k
@rem --- ファイルがドラッグされているとき
) else (
@echo off
@rem --- exeファイルの削除
del %exefile%
@rem --- コンパイル実行
csc -nologo %str%
@rem --- コンパイル成功時
@if exist %exefile% (
cls
%exefile%
) else (
pause >NUL
)
)

