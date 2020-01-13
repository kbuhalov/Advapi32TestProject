# Advapi32TestProject
Represents the sample unity project to reproduce "Unable to find advapi32" error.

```
2020-01-13 14:25:39.169 15718-15765/? I/Unity: !!!!!Create new client web socket
    UnityEngine.Logger:Log(LogType, Object)
    TestConnection:.ctor()
    System.Array:UnsafeStore(T[], Int32, T)
    TestConnection:Connect()
     
    (Filename: ./Runtime/Export/Debug/Debug.bindings.h Line: 35)
2020-01-13 14:25:39.180 15718-15765/? E/Unity: Unable to find advapi32
2020-01-13 14:25:39.184 15718-15765/? W/Unity: Plugins: Couldn't open advapi32, error: dlopen failed: library "advapi32" not found
    Microsoft.Win32.ManifestEtw:EventRegister(Guid&, EtwEnableCallback, Void*, Int64&)
    System.Diagnostics.Tracing.EventProvider:Register(Guid)
    System.Diagnostics.Tracing.EventSource:Initialize(Guid, String, String[])
    System.Diagnostics.Tracing.EventSource:.ctor(EventSourceSettings, String[])
    System.Net.NetEventSource:.cctor()
    System.Net.WebSockets.ClientWebSocket:.ctor()
    TestConnection:.ctor()
    System.Array:UnsafeStore(T[], Int32, T)
    TestConnection:Connect()
    
    [./Runtime/Misc/Plugins.cpp line 306] 
    (Filename: ./Runtime/Misc/Plugins.cpp Line: 306)
2020-01-13 14:25:39.188 5199-9627/? D/com.xiaomi.common.Network: Http POST Response Code: 200
2020-01-13 14:25:39.199 15718-15765/? I/Unity: !!!!!Socket created
    UnityEngine.Logger:Log(LogType, Object)
    TestConnection:.ctor()
    System.Array:UnsafeStore(T[], Int32, T)
    TestConnection:Connect()
     
    (Filename: ./Runtime/Export/Debug/Debug.bindings.h Line: 35)
2020-01-13 14:25:39.200 15718-15765/? I/Unity: !!!!!Establishing Connection to wss://echo.websocket.org/
    UnityEngine.Logger:Log(LogType, Object)
    TestConnection:.ctor()
    System.Array:UnsafeStore(T[], Int32, T)
    TestConnection:Connect()
     
    (Filename: ./Runtime/Export/Debug/Debug.bindings.h Line: 35)
2020-01-13 14:25:39.273 15718-15765/? E/Unity: SocketException: Could not resolve host 'echo.websocket.org'
      at System.Net.Dns.Error_11001 (System.String hostName) [0x00000] in <00000000000000000000000000000000>:0 
      at System.Net.Dns.hostent_to_IPHostEntry (System.String originalHostName, System.String h_name, System.String[] h_aliases, System.String[] h_addrlist) [0x00000] in <00000000000000000000000000000000>:0 
      at System.Net.Dns.GetHostByName (System.String hostName) [0x00000] in <00000000000000000000000000000000>:0 
      at System.Net.Dns.GetHostEntry (System.String hostNameOrAddress) [0x00000] in <00000000000000000000000000000000>:0 
      at System.Net.Dns.GetHostAddresses (System.String hostNameOrAddress) [0x00000] in <00000000000000000000000000000000>:0 
      at System.Threading.ThreadPoolWorkQueue.Dispatch () [0x00000] in <00000000000000000000000000000000>:0 
    --- End of stack trace from previous location where exception was thrown ---
      at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x00000] in <00000000000000000000000000000000>:0
```
