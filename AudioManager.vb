Imports System.Runtime.InteropServices

Public Class AudioManager

    Private Const CLSCTX_ALL As UInteger = 23 ' CLSCTX_ALL para CoCreateInstance

    Public Function SetApplicationVolume(applicationName As String, volume As Single) As Boolean
        Dim deviceEnumerator As Object = Nothing
        Dim result As Integer = CoCreateInstance(AudioSessionControl.CLSID_MMDeviceEnumerator, IntPtr.Zero, CLSCTX_ALL, AudioSessionControl.IID_IAudioSessionManager2, deviceEnumerator)
        If result <> 0 Then
            Throw New COMException("CoCreateInstance failed", result)
        End If

        Dim sessionManager As AudioSessionControl.IAudioSessionManager2 = CType(deviceEnumerator, AudioSessionControl.IAudioSessionManager2)
        Dim sessionEnumerator As Object = Nothing
        sessionManager.GetSessionEnumerator(sessionEnumerator)

        Dim sessions As AudioSessionControl.IAudioSessionControl2() = CType(sessionEnumerator, AudioSessionControl.IAudioSessionControl2())
        For Each session In sessions
            Dim sessionControl2 As AudioSessionControl.IAudioSessionControl2 = TryCast(session, AudioSessionControl.IAudioSessionControl2)
            If sessionControl2 IsNot Nothing Then
                Dim processId As Integer = sessionControl2.ProcessID
                Dim processName As String = Process.GetProcessById(processId).ProcessName
                If processName.Equals(applicationName, StringComparison.OrdinalIgnoreCase) Then
                    Dim volumeLevel As Single
                    sessionControl2.SetSimpleVolume(volume, True, volumeLevel)
                    Return True
                End If
            End If
        Next

        Return False
    End Function

    Public Function SetMasterVolume(volume As Single) As Boolean
        Dim deviceEnumerator As Object = Nothing
        Dim result As Integer = CoCreateInstance(AudioSessionControl.CLSID_MMDeviceEnumerator, IntPtr.Zero, CLSCTX_ALL, AudioSessionControl.IID_IAudioSessionManager2, deviceEnumerator)
        If result <> 0 Then
            Throw New COMException("CoCreateInstance failed", result)
        End If

        Dim sessionManager As AudioSessionControl.IAudioSessionManager2 = CType(deviceEnumerator, AudioSessionControl.IAudioSessionManager2)
        Return sessionManager.SetSimpleAudioVolume(volume) = 0
    End Function

    Public Function GetApplicationVolume(applicationName As String, ByRef volume As Single) As Boolean
        Dim deviceEnumerator As Object = Nothing
        Dim result As Integer = CoCreateInstance(AudioSessionControl.CLSID_MMDeviceEnumerator, IntPtr.Zero, CLSCTX_ALL, AudioSessionControl.IID_IAudioSessionManager2, deviceEnumerator)
        If result <> 0 Then
            Throw New COMException("CoCreateInstance failed", result)
        End If

        Dim sessionManager As AudioSessionControl.IAudioSessionManager2 = CType(deviceEnumerator, AudioSessionControl.IAudioSessionManager2)
        Dim sessionEnumerator As Object = Nothing
        sessionManager.GetSessionEnumerator(sessionEnumerator)

        Dim sessions As AudioSessionControl.IAudioSessionControl2() = CType(sessionEnumerator, AudioSessionControl.IAudioSessionControl2())
        For Each session In sessions
            Dim sessionControl2 As AudioSessionControl.IAudioSessionControl2 = TryCast(session, AudioSessionControl.IAudioSessionControl2)
            If sessionControl2 IsNot Nothing Then
                Dim processId As Integer = sessionControl2.ProcessID
                Dim processName As String = Process.GetProcessById(processId).ProcessName
                If processName.Equals(applicationName, StringComparison.OrdinalIgnoreCase) Then
                    Dim currentVolume As Single
                    Dim volumeScalar As Boolean
                    sessionControl2.GetSimpleVolume(currentVolume, volumeScalar)
                    volume = currentVolume
                    Return True
                End If
            End If
        Next

        Return False
    End Function

End Class
