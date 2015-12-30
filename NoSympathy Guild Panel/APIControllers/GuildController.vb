Imports System.Net
Imports Models
Imports Newtonsoft.Json

Public Class GuildController
    Inherits BaseController
    Public Function GetGuildMembers(Optional access_token As String = APICore.NosSettings.GuildLeaderAccessToken) As List(Of Member)
        Dim endPoints As Uri
        Dim jsonres As String
        Dim ret As List(Of Member)

        endPoints = New Uri(String.Format(APICore.Gw2Endpoints.BaseUrl + APICore.Gw2Endpoints.GuildMember, APICore.NosSettings.GuildId, access_token))

        jsonres = GetApiDataByUriJson(endPoints)

        ret = JsonConvert.DeserializeObject(Of List(Of Member))(jsonres)



        Return ret
    End Function

    Public Function GetGuildLogs(Optional access_token As String = APICore.NosSettings.GuildLeaderAccessToken) As List(Of GuildLogs)
        Dim endPoints = New Uri(String.Format(APICore.Gw2Endpoints.BaseUrl + APICore.Gw2Endpoints.GuildLogs, APICore.NosSettings.GuildId, access_token))
        Dim jsonres = GetApiDataByUriJson(endPoints)
        Dim ret = JsonConvert.DeserializeObject(Of List(Of GuildLogs))(jsonres)
        Return ret
    End Function


    Public Function GetGuildRanks(Optional access_token As String = APICore.NosSettings.GuildLeaderAccessToken) As List(Of GuildRank)
        Dim endPoints = New Uri(String.Format(APICore.Gw2Endpoints.BaseUrl + APICore.Gw2Endpoints.GuildRanks, APICore.NosSettings.GuildId, access_token))
        Dim jsonres = GetApiDataByUriJson(endPoints)
        Dim ret = JsonConvert.DeserializeObject(Of List(Of GuildRank))(jsonres)

        Return ret
    End Function

End Class
