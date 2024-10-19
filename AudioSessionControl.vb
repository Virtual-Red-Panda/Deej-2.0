Imports System.Runtime.InteropServices

Module AudioSessionControl

    ' GUIDs para las interfaces
    Public ReadOnly CLSID_MMDeviceEnumerator As New Guid("BCDE0395-E52F-467C-8E3D-C4579291692E")
    Public ReadOnly IID_IAudioSessionManager2 As New Guid("BFA971F1-4D5E-4E8D-9E70-3A2C6C303B16")
    Public ReadOnly IID_IAudioSessionControl As New Guid("B9E1A4E4-B1E4-4E29-8C1F-9C7486CEBB0B")
    Public ReadOnly IID_IAudioSessionControl2 As New Guid("BFA971F1-4D5E-4E8D-9E70-3A2C6C303B16")

    <ComImport>
    <Guid("BFA971F1-4D5E-4E8D-9E70-3A2C6C303B16")>
    <InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
    Interface IAudioSessionControl
        <PreserveSig>
        Function GetSessionIdentifier(<Out> ByRef sessionId As String) As Integer

        <PreserveSig>
        Function GetDisplayName(<Out> ByRef displayName As String) As Integer

        <PreserveSig>
        Function SetDisplayName(<[In]> displayName As String, <[In]> eventContext As Guid) As Integer

        <PreserveSig>
        Function SetIconPath(<[In]> iconPath As String, <[In]> eventContext As Guid) As Integer

        <PreserveSig>
        Function GetProcessId(<Out> ByRef processId As Integer) As Integer
    End Interface

    <ComImport>
    <Guid("BCDE0395-E52F-467C-8E3D-C4579291692E")>
    <InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
    Interface IAudioSessionManager2
        <PreserveSig>
        Function GetSimpleAudioVolume(<Out> ByRef volume As Single) As Integer

        <PreserveSig>
        Function SetSimpleAudioVolume(<[In]> volume As Single) As Integer

        <PreserveSig>
        Function GetSessionEnumerator(<Out> ByRef sessionEnumerator As Object) As Integer
    End Interface

    <DllImport("ole32.dll")>
    Function CoCreateInstance(ByRef clsid As Guid, ByVal outer As IntPtr, ByVal clsContext As UInteger, ByRef iid As Guid, ByRef instance As Object) As Integer

End Module
