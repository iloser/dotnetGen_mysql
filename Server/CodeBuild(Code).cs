using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Text;
using System.Text.RegularExpressions;
using Model;

namespace Server {

	internal partial class CodeBuild {
		public void SetOutput(bool[] outputs) {
			if (this._tables.Count == outputs.Length) {
				for (int a = 0; a < outputs.Length; a++) {
					this._tables[a].IsOutput = outputs[a];
				}
			}
		}

		public List<BuildInfo> Build(string solutionName, bool isSolution, bool isMakeAdmin, bool isDownloadRes) {
			Logger.remotor.Info("Build: " + solutionName + ",isSolution: " + isSolution + ",isMakeAdmin: " + isMakeAdmin + ",isDownloadRes: " + isDownloadRes + "(" + _client.Server + "," + _client.Username + "," + _client.Password + "," + _client.Database + ")");
			List<BuildInfo> loc1 = new List<BuildInfo>();

			//solutionName = CodeBuild.UFString(solutionName);
			string dbName = CodeBuild.UFString(CodeBuild.GetCSName(_client.Database));
			string connectionStringName = _client.Database + "ConnectionString";
			string basicName = "Build";

			string wwwroot_sitemap = "";

			Dictionary<string, bool> isMakedHtmlSelect = new Dictionary<string, bool>();
			StringBuilder Model_Build_ExtensionMethods_cs = new StringBuilder();
			List<string> admin_controllers_syscontroller_init_sysdir = new List<string>();

			StringBuilder sb1 = new StringBuilder();
			StringBuilder sb2 = new StringBuilder();
			StringBuilder sb3 = new StringBuilder();
			StringBuilder sb4 = new StringBuilder();
			StringBuilder sb5 = new StringBuilder();
			StringBuilder sb6 = new StringBuilder();
			StringBuilder sb7 = new StringBuilder();
			StringBuilder sb8 = new StringBuilder();
			StringBuilder sb9 = new StringBuilder();
			StringBuilder sb10 = new StringBuilder();
			StringBuilder sb11 = new StringBuilder();
			StringBuilder sb12 = new StringBuilder();
			StringBuilder sb13 = new StringBuilder();
			StringBuilder sb14 = new StringBuilder();
			StringBuilder sb15 = new StringBuilder();
			StringBuilder sb16 = new StringBuilder();
			StringBuilder sb17 = new StringBuilder();
			StringBuilder sb18 = new StringBuilder();
			StringBuilder sb19 = new StringBuilder();
			StringBuilder sb20 = new StringBuilder();
			StringBuilder sb21 = new StringBuilder();
			StringBuilder sb22 = new StringBuilder();
			StringBuilder sb23 = new StringBuilder();
			StringBuilder sb24 = new StringBuilder();
			StringBuilder sb25 = new StringBuilder();
			StringBuilder sb26 = new StringBuilder();
			StringBuilder sb27 = new StringBuilder();
			StringBuilder sb28 = new StringBuilder();
			StringBuilder sb29 = new StringBuilder();
			AnonymousHandler clearSb = delegate () {
				sb1.Remove(0, sb1.Length);
				sb2.Remove(0, sb2.Length);
				sb3.Remove(0, sb3.Length);
				sb4.Remove(0, sb4.Length);
				sb5.Remove(0, sb5.Length);
				sb6.Remove(0, sb6.Length);
				sb7.Remove(0, sb7.Length);
				sb8.Remove(0, sb8.Length);
				sb9.Remove(0, sb9.Length);
				sb10.Remove(0, sb10.Length);
				sb11.Remove(0, sb11.Length);
				sb12.Remove(0, sb12.Length);
				sb13.Remove(0, sb13.Length);
				sb14.Remove(0, sb14.Length);
				sb15.Remove(0, sb15.Length);
				sb16.Remove(0, sb16.Length);
				sb17.Remove(0, sb17.Length);
				sb18.Remove(0, sb18.Length);
				sb19.Remove(0, sb19.Length);
				sb20.Remove(0, sb20.Length);
				sb21.Remove(0, sb21.Length);
				sb22.Remove(0, sb22.Length);
				sb23.Remove(0, sb23.Length);
				sb24.Remove(0, sb24.Length);
				sb25.Remove(0, sb25.Length);
				sb26.Remove(0, sb26.Length);
				sb27.Remove(0, sb27.Length);
				sb28.Remove(0, sb28.Length);
				sb29.Remove(0, sb29.Length);
			};

			if (isSolution) {
				#region solution.sln
				sb1.AppendFormat(CONST.sln, solutionName,
					Guid.NewGuid().ToString().ToUpper(),
					Guid.NewGuid().ToString().ToUpper(),
					Guid.NewGuid().ToString().ToUpper(),
					Guid.NewGuid().ToString().ToUpper(),
					Guid.NewGuid().ToString().ToUpper(),
					Guid.NewGuid().ToString().ToUpper(),
					Guid.NewGuid().ToString().ToUpper(),
					Guid.NewGuid().ToString().ToUpper(),
					Guid.NewGuid().ToString().ToUpper(),
					Guid.NewGuid().ToString().ToUpper());
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"..\", solutionName, ".sln"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion

				#region Project Common
				#region Lib/BmwNet.cs
				sb1.AppendFormat(CONST.Common_BmwNet_cs, solutionName);
				//loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\Lib\BmwNet.cs"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region Lib/IniHelper.cs
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\Lib\IniHelper.cs"), Deflate.Compress(Properties.Resources.Lib_IniHelper_cs)));
				clearSb();
				#endregion
				#region Lib/JSDecoder.cs
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\Lib\JSDecoder.cs"), Deflate.Compress(Properties.Resources.Lib_JSDecoder_cs)));
				clearSb();
				#endregion
				#region Lib/Lib.cs
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\Lib\Lib.cs"), Deflate.Compress(Properties.Resources.Lib_Lib_cs)));
				clearSb();
				#endregion

				#region WinFormClass/Socket/BaseSocket.cs
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\WinFormClass\Socket\BaseSocket.cs"), Deflate.Compress(Properties.Resources.WinFormClass_Socket_BaseSocket_cs)));
				clearSb();
				#endregion
				#region WinFormClass/Socket/ClientSocket.cs
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\WinFormClass\Socket\ClientSocket.cs"), Deflate.Compress(Properties.Resources.WinFormClass_Socket_ClientSocket_cs)));
				clearSb();
				#endregion
				#region WinFormClass/Socket/ServerSocket.cs
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\WinFormClass\Socket\ServerSocket.cs"), Deflate.Compress(Properties.Resources.WinFormClass_Socket_ServerSocket_cs)));
				clearSb();
				#endregion
				#region WinFormClass/Robot.cs
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\WinFormClass\Robot.cs"), Deflate.Compress(Properties.Resources.WinFormClass_Robot_cs)));
				clearSb();
				#endregion
				#region WinFormClass/WorkQueue.cs
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\WinFormClass\WorkQueue.cs"), Deflate.Compress(Properties.Resources.WinFormClass_WorkQueue_cs)));
				clearSb();
				#endregion

				#region CSRedis
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\ConnectionPool.cs"), Deflate.Compress(Properties.Resources.CSRedis_ConnectionPool_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Events.cs"), Deflate.Compress(Properties.Resources.CSRedis_Events_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Exceptions.cs"), Deflate.Compress(Properties.Resources.CSRedis_Exceptions_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\IRedisClient.cs"), Deflate.Compress(Properties.Resources.CSRedis_IRedisClient_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\IRedisClientAsync.cs"), Deflate.Compress(Properties.Resources.CSRedis_IRedisClientAsync_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\IRedisClientSync.cs"), Deflate.Compress(Properties.Resources.CSRedis_IRedisClientSync_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\QuickHelperBase.cs"), Deflate.Compress(Properties.Resources.CSRedis_QuickHelperBase_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\RedisClient.Async.cs"), Deflate.Compress(Properties.Resources.CSRedis_RedisClient_Async_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\RedisClient.cs"), Deflate.Compress(Properties.Resources.CSRedis_RedisClient_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\RedisClient.Sync.cs"), Deflate.Compress(Properties.Resources.CSRedis_RedisClient_Sync_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\RedisConnectionPool.cs"), Deflate.Compress(Properties.Resources.CSRedis_RedisConnectionPool_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\RedisSentinelClient.Async.cs"), Deflate.Compress(Properties.Resources.CSRedis_RedisSentinelClient_Async_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\RedisSentinelClient.cs"), Deflate.Compress(Properties.Resources.CSRedis_RedisSentinelClient_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\RedisSentinelClient.Sync.cs"), Deflate.Compress(Properties.Resources.CSRedis_RedisSentinelClient_Sync_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\RedisSentinelManager.cs"), Deflate.Compress(Properties.Resources.CSRedis_RedisSentinelManager_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Types.cs"), Deflate.Compress(Properties.Resources.CSRedis_Types_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\MonitorListener.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_MonitorListener_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\RedisCommand.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_RedisCommand_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\RedisConnector.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_RedisConnector_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\RedisListener.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_RedisListener_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\RedisPipeline.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_RedisPipeline_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\RedisTransaction.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_RedisTransaction_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\SubscriptionListener.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_SubscriptionListener_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Commands\RedisArray.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Commands_RedisArray_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Commands\RedisBool.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Commands_RedisBool_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Commands\RedisBytes.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Commands_RedisBytes_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Commands\RedisDate.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Commands_RedisDate_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Commands\RedisFloat.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Commands_RedisFloat_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Commands\RedisHash.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Commands_RedisHash_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Commands\RedisInt.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Commands_RedisInt_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Commands\RedisIsMasterDownByAddrCommand.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Commands_RedisIsMasterDownByAddrCommand_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Commands\RedisObject.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Commands_RedisObject_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Commands\RedisRoleCommand.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Commands_RedisRoleCommand_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Commands\RedisScanCommand.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Commands_RedisScanCommand_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Commands\RedisSlowLogCommand.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Commands_RedisSlowLogCommand_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Commands\RedisStatus.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Commands_RedisStatus_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Commands\RedisString.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Commands_RedisString_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Commands\RedisSubscription.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Commands_RedisSubscription_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Commands\RedisTuple.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Commands_RedisTuple_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Fakes\FakeRedisSocket.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Fakes_FakeRedisSocket_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Fakes\FakeStream.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Fakes_FakeStream_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\IO\AsyncConnector.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_IO_AsyncConnector_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\IO\IRedisSocket.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_IO_IRedisSocket_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\IO\RedisAsyncCommandToken.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_IO_RedisAsyncCommandToken_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\IO\RedisIO.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_IO_RedisIO_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\IO\RedisPooledSocket.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_IO_RedisPooledSocket_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\IO\RedisReader.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_IO_RedisReader_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\IO\RedisSocket.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_IO_RedisSocket_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\IO\RedisWriter.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_IO_RedisWriter_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\IO\SocketAsyncPool.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_IO_SocketAsyncPool_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\IO\SocketPool.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_IO_SocketPool_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Utilities\RedisArgs.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Utilities_RedisArgs_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\CSRedis\Internal\Utilities\Serializer.cs"), Deflate.Compress(Properties.Resources.CSRedis_Internal_Utilities_Serializer_cs)));
				#endregion
				#region StackExchange.Redis
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\StackExchange.Redis\ConnectionMultiplexerPool.cs"), Deflate.Compress(Properties.Resources.StackExchange_Redis_ConnectionMultiplexerPool_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\StackExchange.Redis\QuickHelperBase.cs"), Deflate.Compress(Properties.Resources.StackExchange_Redis_QuickHelperBase_cs)));
				#endregion
				#region Microsoft.Extensions.Caching.Redis
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\Microsoft.Extensions.Caching.Redis\RedisCache.cs"), Deflate.Compress(Properties.Resources.Microsoft_Extensions_Caching_Redis_RedisSuperCache_cs)));
				clearSb();
				#endregion

				#region MySql.Data.MySqlClient
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\MySql.Data.MySqlClient\ConnectionPool.cs"), Deflate.Compress(Properties.Resources.MySql_Data_MySqlClient_ConnectionPool_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\MySql.Data.MySqlClient\Executer.cs"), Deflate.Compress(Properties.Resources.MySql_Data_MySqlClient_Executer_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\MySql.Data.MySqlClient\SelectBuild.cs"), Deflate.Compress(Properties.Resources.MySql_Data_MySqlClient_SelectBuild_cs)));
				clearSb();
				#endregion

				#region NPinyin
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\NPinyin\Pinyin.cs"), Deflate.Compress(Properties.Resources.NPinyin_Pinyin_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\NPinyin\PyCode.cs"), Deflate.Compress(Properties.Resources.NPinyin_PyCode_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\NPinyin\PyHash.cs"), Deflate.Compress(Properties.Resources.NPinyin_PyHash_cs)));
				clearSb();
				#endregion

				#region plist-cil
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\plist-cil\ASCIIPropertyListParser.cs"), Deflate.Compress(Properties.Resources.plist_cil_ASCIIPropertyListParser_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\plist-cil\BinaryPropertyListParser.cs"), Deflate.Compress(Properties.Resources.plist_cil_BinaryPropertyListParser_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\plist-cil\BinaryPropertyListWriter.cs"), Deflate.Compress(Properties.Resources.plist_cil_BinaryPropertyListWriter_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\plist-cil\NSArray.cs"), Deflate.Compress(Properties.Resources.plist_cil_NSArray_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\plist-cil\NSArray.IList.cs"), Deflate.Compress(Properties.Resources.plist_cil_NSArray_IList_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\plist-cil\NSData.cs"), Deflate.Compress(Properties.Resources.plist_cil_NSData_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\plist-cil\NSDate.cs"), Deflate.Compress(Properties.Resources.plist_cil_NSDate_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\plist-cil\NSDictionary.cs"), Deflate.Compress(Properties.Resources.plist_cil_NSDictionary_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\plist-cil\NSNumber.cs"), Deflate.Compress(Properties.Resources.plist_cil_NSNumber_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\plist-cil\NSObject.cs"), Deflate.Compress(Properties.Resources.plist_cil_NSObject_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\plist-cil\NSSet.cs"), Deflate.Compress(Properties.Resources.plist_cil_NSSet_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\plist-cil\NSString.cs"), Deflate.Compress(Properties.Resources.plist_cil_NSString_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\plist-cil\PropertyListException.cs"), Deflate.Compress(Properties.Resources.plist_cil_PropertyListException_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\plist-cil\PropertyListFormatException.cs"), Deflate.Compress(Properties.Resources.plist_cil_PropertyListFormatException_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\plist-cil\PropertyListParser.cs"), Deflate.Compress(Properties.Resources.plist_cil_PropertyListParser_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\plist-cil\UID.cs"), Deflate.Compress(Properties.Resources.plist_cil_UID_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\plist-cil\XmlPropertyListParser.cs"), Deflate.Compress(Properties.Resources.plist_cil_XmlPropertyListParser_cs)));
				clearSb();
				#endregion

				#region FastExcel
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\FastExcel\Cell.cs"), Deflate.Compress(Properties.Resources.FastExcel_Cell_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\FastExcel\FastExcel.Add.cs"), Deflate.Compress(Properties.Resources.FastExcel_FastExcel_Add_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\FastExcel\FastExcel.cs"), Deflate.Compress(Properties.Resources.FastExcel_FastExcel_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\FastExcel\FastExcel.Delete.cs"), Deflate.Compress(Properties.Resources.FastExcel_FastExcel_Delete_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\FastExcel\FastExcel.Read.cs"), Deflate.Compress(Properties.Resources.FastExcel_FastExcel_Read_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\FastExcel\FastExcel.Update.cs"), Deflate.Compress(Properties.Resources.FastExcel_FastExcel_Update_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\FastExcel\FastExcel.Worksheets.cs"), Deflate.Compress(Properties.Resources.FastExcel_FastExcel_Worksheets_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\FastExcel\FastExcel.Write.cs"), Deflate.Compress(Properties.Resources.FastExcel_FastExcel_Write_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\FastExcel\Row.cs"), Deflate.Compress(Properties.Resources.FastExcel_Row_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\FastExcel\SharedStrings.cs"), Deflate.Compress(Properties.Resources.FastExcel_SharedStrings_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\FastExcel\WorksheetAddSettings.cs"), Deflate.Compress(Properties.Resources.FastExcel_WorksheetAddSettings_cs)));
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\FastExcel\Worksheet.cs"), Deflate.Compress(Properties.Resources.FastExcel_Worksheet_cs)));
				clearSb();
				#endregion

				#region Common.csproj
				sb1.Append(CONST.Common_csproj);
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Common\Common.csproj"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#endregion

				#region Project Infrastructure
				#region Controllers\BaseController.cs
				sb1.Append(Server.Properties.Resources.Infrastructure_Controllers_BaseController_cs);
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Infrastructure\Controllers\BaseController.cs"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region Controllers\CustomExceptionFilter.cs
				sb1.Append(Server.Properties.Resources.Infrastructure_Controllers_CustomExceptionFilter_cs);
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Infrastructure\Controllers\CustomExceptionFilter.cs"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region Extensions\GlobalExtensions.cs
				sb1.Append(Server.Properties.Resources.Infrastructure_Extensions_GlobalExtensions_cs);
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Infrastructure\Extensions\GlobalExtensions.cs"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region ModuleBasic\IModuleInitializer.cs
				sb1.Append(Server.Properties.Resources.Infrastructure_ModuleBasic_IModuleInitializer_cs);
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Infrastructure\ModuleBasic\IModuleInitializer.cs"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region ModuleBasic\ModuleInfo.cs
				sb1.Append(Server.Properties.Resources.Infrastructure_ModuleBasic_ModuleInfo_cs);
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Infrastructure\ModuleBasic\ModuleInfo.cs"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region ModuleBasic\ModuleViewLocationExpander.cs
				sb1.Append(Server.Properties.Resources.Infrastructure_ModuleBasic_ModuleViewLocationExpander_cs);
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Infrastructure\ModuleBasic\ModuleViewLocationExpander.cs"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region Infrastructure.csproj
				sb1.AppendFormat(CONST.Infrastructure_csproj, solutionName);
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Infrastructure\Infrastructure.csproj"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#endregion
			}

			foreach (TableInfo table in _tables) {
				if (table.IsOutput == false) continue;
				if (table.Type == "P") continue;

				//if (table.Uniques.Count == 0) {
				//	throw new Exception("检查到表 “" + table.Owner + "." + table.Name + "” 没有设定惟一键！");
				//}
				if (table.Columns.Count == 0) continue;

				#region commom variable define
				string uClass_Name = CodeBuild.UFString(table.ClassName);
				string nClass_Name = table.ClassName;
				string nTable_Name = string.Concat("`", string.IsNullOrEmpty(table.Owner) ? string.Empty : string.Concat(table.Owner, "."), table.Name, "`");
				string Class_Name_BLL_Full = string.Format(@"{0}.BLL.{1}", solutionName, uClass_Name);
				string Class_Name_Model_Full = string.Format(@"{0}.Model.{1}", solutionName, uClass_Name);

				string pkCsParam = "";
				string pkCsParamNoType = "";
				string pkCsParamNoTypeByval = "";
				string pkSqlParamFormat = "";
				string pkSqlParam = "";
				string pkSpNotNull = "";
				string pkEvalsQuerystring = "";
				string CsParam1 = "";
				string CsParamNoType1 = "";
				string CsParam2 = "";
				string CsParamNoType2 = "";
				string pkMvcRoute = "";
				string orderBy = table.Clustereds.Count > 0 ?
					string.Join(", ", table.Clustereds.ConvertAll<string>(delegate (ColumnInfo cli) {
						return "a.`" + cli.Name + "`" + (cli.Orderby == DataSort.ASC ? string.Empty : string.Concat(" ", cli.Orderby));
					}).ToArray()) :
					table.Uniques.Count > 0 ?
						string.Join(", ", table.Uniques[0].ConvertAll<string>(delegate (ColumnInfo cli) {
							return "a.`" + cli.Name + "`" + (cli.Orderby == DataSort.ASC ? string.Empty : string.Concat(" ", cli.Orderby));
						}).ToArray()) : "";

				int pkSqlParamFormat_idx = -1;
				if (table.PrimaryKeys.Count > 0) {
					foreach (ColumnInfo columnInfo in table.PrimaryKeys) {
						pkCsParam += CodeBuild.GetCSType(columnInfo.Type, uClass_Name + columnInfo.Name.ToUpper()).Replace("?", "") + " " + CodeBuild.UFString(columnInfo.Name) + ", ";
						pkCsParamNoType += CodeBuild.UFString(columnInfo.Name) + ", ";
						pkCsParamNoTypeByval += string.Format(GetCSTypeValue(columnInfo.Type), CodeBuild.UFString(columnInfo.Name)) + ", ";
						pkSqlParamFormat += "`" + columnInfo.Name + "` = {" + ++pkSqlParamFormat_idx + "} AND ";
						pkSqlParam += "`" + columnInfo.Name + "` = ?" + columnInfo.Name + " AND ";
						pkSpNotNull += "isnull(?" + columnInfo.Name + ") = 0 AND ";
						pkEvalsQuerystring += string.Format("{0}=<%# Eval(\"{0}\") %>&", CodeBuild.UFString(columnInfo.Name));
						pkMvcRoute += "{" + CodeBuild.UFString(columnInfo.Name) + "}/";
					}
					pkCsParam = pkCsParam.Substring(0, pkCsParam.Length - 2);
					pkCsParamNoType = pkCsParamNoType.Substring(0, pkCsParamNoType.Length - 2);
					pkCsParamNoTypeByval = pkCsParamNoTypeByval.Substring(0, pkCsParamNoTypeByval.Length - 2);
					pkSqlParamFormat = pkSqlParamFormat.Substring(0, pkSqlParamFormat.Length - 5);
					pkSqlParam = pkSqlParam.Substring(0, pkSqlParam.Length - 5);
					pkSpNotNull = pkSpNotNull.Substring(0, pkSpNotNull.Length - 5);
					pkEvalsQuerystring = pkEvalsQuerystring.Substring(0, pkEvalsQuerystring.Length - 1);
				}
				foreach (ColumnInfo columnInfo in table.Columns) {
					CsParam1 += CodeBuild.GetCSType(columnInfo.Type, uClass_Name + columnInfo.Name.ToUpper()) + " " + CodeBuild.UFString(columnInfo.Name) + ", ";
					CsParamNoType1 += CodeBuild.UFString(columnInfo.Name) + ", ";
					if (columnInfo.IsIdentity) {
						//CsParamNoType2 += "0, ";
					} else {
						CsParam2 += CodeBuild.GetCSType(columnInfo.Type, uClass_Name + columnInfo.Name.ToUpper()) + " " + CodeBuild.UFString(columnInfo.Name) + ", ";
						CsParamNoType2 += string.Format("\r\n				{0} = {0}, ", CodeBuild.UFString(columnInfo.Name));
					}
				}
				CsParam1 = CsParam1.Substring(0, CsParam1.Length - 2);
				CsParamNoType1 = CsParamNoType1.Substring(0, CsParamNoType1.Length - 2);
				if (CsParam2.Length > 0) CsParam2 = CsParam2.Substring(0, CsParam2.Length - 2);
				if (CsParamNoType2.Length > 0) CsParamNoType2 = CsParamNoType2.Substring(0, CsParamNoType2.Length - 2);
				#endregion

				#region Model *.cs
				sb1.AppendFormat(
	@"using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace {0}.Model {{

	[JsonObject(MemberSerialization.OptIn)]
	public partial class {1}Info {{
		#region fields
", solutionName, uClass_Name);
				Dictionary<string, string> innerjoinObjs = new Dictionary<string, string>();
				bool Is_System_ComponentModel = false;
				int column_idx = -1;
				foreach (ColumnInfo column in table.Columns) {
					column_idx++;
					string csType = CodeBuild.GetCSType(column.Type, uClass_Name + column.Name.ToUpper());
					string nColumn_Name = column.Name;
					string uColumn_Name = CodeBuild.UFString(column.Name);
					string comment = _column_coments[table.FullName][column.Name];
					string prototype_comment = comment == column.Name ? "" : string.Format(@"/// <summary>
		/// {0}
		/// </summary>
		", comment);

					sb1.AppendFormat(
	@"		private {0} _{1};
", csType, uColumn_Name);

					if (column.Type == MySqlDbType.Enum || column.Type == MySqlDbType.Set) {
						#region 生成 Enum/Set 枚举类型
						sb16.AppendFormat(@"
	{2}public enum {0}{1} {{
		", uClass_Name, column.Name.ToUpper() + (column.Type == MySqlDbType.Set ? " : long" : ""), column.Type == MySqlDbType.Set ? "[Flags]\r\n	" : "");
						string slkdgjlksdjg = "";
						int field_idx = 0;
						int unknow_idx = 0;
						string exp2 = string.Concat(column.SqlType);
						int quote_pos = -1;
						while (true) {
							int first_pos = quote_pos = exp2.IndexOf('\'', quote_pos + 1);
							if (quote_pos == -1) break;
							while (true) {
								quote_pos = exp2.IndexOf('\'', quote_pos + 1);
								if (quote_pos == -1) break;
								int r_cout = 0;
								//for (int p = 1; true; p++) {
								//	if (exp2[quote_pos - p] == '\\') r_cout++;
								//	else break;
								//}
								while(exp2[++quote_pos] == '\'') r_cout++;
								if (r_cout % 2 == 0/* && quote_pos - first_pos > 2*/) {
									string str2 = exp2.Substring(first_pos + 1, quote_pos - first_pos - 2).Replace("''", "'");
									if (Regex.IsMatch(str2, @"^[\u0391-\uFFE5a-zA-Z_\$][\u0391-\uFFE5a-zA-Z_\$\d]*$"))
										slkdgjlksdjg += ", " + str2;
									else {
										slkdgjlksdjg += string.Format(@", 
		/// <summary>
		/// {0}
		/// </summary>
		[Description(""{0}"")]
		Unknow{1}", str2.Replace("\"", "\\\""), ++unknow_idx);
										Is_System_ComponentModel = true;
									}
									if (column.Type == MySqlDbType.Set)
										slkdgjlksdjg += " = " + Math.Pow(2, field_idx++);
									if (column.Type == MySqlDbType.Enum && field_idx++ == 0)
										slkdgjlksdjg += " = 1";
									break;
								}
							}
							if (quote_pos == -1) break;
						}
						sb16.Append(slkdgjlksdjg.Substring(2).TrimStart('\r', '\n', '\t'));
						sb16.AppendFormat(@"
	}}");
						#endregion
					}

					string tmpinfo = string.Empty;
					List<string> tsvarr = new List<string>();
					List<ForeignKeyInfo> fks = table.ForeignKeys.FindAll(delegate (ForeignKeyInfo fk) {
						int fkc1idx = 0;
						string fkcsBy = "By";
						string fkcsParms = string.Empty;
						string fkcsIfNull = string.Empty;
						ColumnInfo fkc = fk.Columns.Find(delegate (ColumnInfo c1) {
							fkc1idx++;
							fkcsParms += string.Format(GetCSTypeValue(c1.Type), "_" + CodeBuild.UFString(c1.Name)) + ", ";
							fkcsIfNull += " && _" + CodeBuild.UFString(c1.Name) + " != null";
							return c1.Name == column.Name;
						});
						if (fk.ReferencedTable != null) {
							fk.ReferencedColumns.ForEach(delegate (ColumnInfo c1) {
								fkcsBy += CodeBuild.UFString(c1.Name) + "And";
							});
						} else {
							fk.ReferencedColumnNames.ForEach(delegate (string c1) {
								fkcsBy += CodeBuild.UFString(c1) + "And";
							});
						}
						if (fkc == null) return false;
						string FK_uClass_Name = fk.ReferencedTable != null ? CodeBuild.UFString(fk.ReferencedTable.ClassName) :
							CodeBuild.UFString(TableInfo.GetClassName(fk.ReferencedTableName));
						string FK_uClass_Name_full = fk.ReferencedTable != null ? FK_uClass_Name :
							string.Format(@"{0}.Model.{1}", solutionName, FK_uClass_Name);
						string FK_uEntry_Name = fk.ReferencedTable != null ? CodeBuild.GetCSName(fk.ReferencedTable.Name) :
							CodeBuild.GetCSName(TableInfo.GetEntryName(fk.ReferencedTableName));
						string tableNamefe3 = fk.ReferencedTable != null ? fk.ReferencedTable.Name : FK_uEntry_Name;
						string memberName = fk.Columns[0].Name.IndexOf(tableNamefe3) == -1 ? CodeBuild.LFString(tableNamefe3) :
							(CodeBuild.LFString(fk.Columns[0].Name.Substring(0, fk.Columns[0].Name.IndexOf(tableNamefe3)) + tableNamefe3));
						if (fk.Columns[0].Name.IndexOf(tableNamefe3) == 0 && fk.ReferencedTable != null) memberName = CodeBuild.LFString(fk.ReferencedTable.ClassName);

						tsvarr.Add(string.Format(@"_obj_{0} = null;", memberName));
						if (fkc1idx == fk.Columns.Count) {
							fkcsBy = fkcsBy.Remove(fkcsBy.Length - 3);
							fkcsParms = fkcsParms.Remove(fkcsParms.Length - 2);
							if (fk.ReferencedColumns.Count > 0 && fk.ReferencedColumns[0].IsPrimaryKey ||
								fk.ReferencedTable == null && fk.ReferencedIsPrimaryKey) {
								fkcsBy = string.Empty;
							}
							sb1.AppendFormat(
@"		private {0}Info _obj_{1};
", FK_uClass_Name_full, memberName);
							tmpinfo += string.Format(
@"		public {0}Info Obj_{1} {{
			get {{
				if (_obj_{1} == null{6}) _obj_{1} = BLL.{5}.GetItem{3}({4});
				return _obj_{1};
			}}
			internal set {{ _obj_{1} = value; }}
		}}
", FK_uClass_Name_full, memberName, solutionName, fkcsBy, fkcsParms, FK_uClass_Name, fkcsIfNull);
							//若不存在 Obj_外键表名，则增加，否则InnerJoin.ToList时会报错 “Obj_外键表名 不存在”
							//比如表只有一 creator_person_id 时，需附加成生一个 Obj_person 属性
							string fkTableClassName = fk.ReferencedTable.ClassName;
							if (memberName == fkTableClassName) {
								//如果有 Obj_外键表名 属性，则不增加什么代码
								if (innerjoinObjs.ContainsKey(fkTableClassName)) innerjoinObjs.Remove(fkTableClassName);
								innerjoinObjs.Add(fkTableClassName, "");
							} else {
								if (innerjoinObjs.ContainsKey(fkTableClassName)) {
									if (!string.IsNullOrEmpty(innerjoinObjs[fkTableClassName]))
										//如果有多个相同外键，比如 a_person_id, b_person_id
										innerjoinObjs[fkTableClassName] = string.Format(
@"
		/// <summary>
		/// 配合 InnerJoin .ToList 查询临时使用
		/// </summary>
		public {0}Info Obj_{1} {{ get; internal set; }}", UFString(fkTableClassName), fkTableClassName, memberName);
								} else
									//如果只有一个外键，比如 a_person_id
									innerjoinObjs.Add(fkTableClassName, string.Format(
@"
		/// <summary>
		/// 与 Obj_{2} 同引用
		/// </summary>
		public {0}Info Obj_{1} {{
			get {{ return this.Obj_{2}; }}
			internal set {{ this.Obj_{2} = value; }}
		}}", UFString(fkTableClassName), fkTableClassName, memberName));
							}
						}
						return fkc != null;
					});
					if (fks.Count > 0) {
						string tmpsetvalue = string.Format(
@"		{2}[JsonProperty] public {0} {1} {{
			get {{ return _{1}; }}
			set {{
				if (_{1} != value) ", csType, uColumn_Name, prototype_comment);
						string tsvstr = string.Join(@"
					", tsvarr.ToArray());
						if (fks.Count > 1) {
							tmpsetvalue += string.Format(@"{{
					{0}
				}}", tsvstr);
						} else {
							tmpsetvalue += tsvstr;
						}
						tmpsetvalue += string.Format(@"
				_{0} = value;
			}}
		}}
", uColumn_Name);
						sb2.Append(tmpsetvalue);
						sb2.Append(tmpinfo);
					} else {
						sb2.AppendFormat(
@"		{2}[JsonProperty] public {0} {1} {{
			get {{ return _{1}; }}
			set {{ _{1} = value; }}
		}}
", csType, uColumn_Name, prototype_comment);
					}
					sb3.AppendFormat("{0} {1}, ", csType, uColumn_Name);
					sb4.AppendFormat(
	@"			_{0} = {0};
", uColumn_Name);
					sb5.AppendFormat(@"
				__jsonIgnore.ContainsKey(""{0}"") ? string.Empty : string.Format("", {0} : {{0}}"", {1}), ", uColumn_Name, CodeBuild.GetToStringFieldConcat(column, uClass_Name + column.Name.ToUpper()));
					if (column.Type == MySqlDbType.Enum)
						sb10.AppendFormat(@"
			if (allField || !__jsonIgnore.ContainsKey(""{0}"")) ht[""{0}""] = {0}?.ToDescriptionOrString();", uColumn_Name);
					else if (column.Type == MySqlDbType.Set)
						sb10.AppendFormat(@"
			if (allField || !__jsonIgnore.ContainsKey(""{0}"")) ht[""{0}""] = {0}?.ToInt64().ToSet<{1}>().Select(a => a.ToDescriptionOrString());", uColumn_Name, uClass_Name + column.Name.ToUpper());
					else
						sb10.AppendFormat(@"
			if (allField || !__jsonIgnore.ContainsKey(""{0}"")) ht[""{0}""] = {0};", uColumn_Name);
					sb7.AppendFormat(@"
				{0}, ""|"",", GetToStringStringify(column));
					if (column.Type == MySqlDbType.Enum)
						sb8.AppendFormat(@"
			if (string.Compare(""null"", ret[{2}]) != 0) item.{0} = ({1})long.Parse(ret[{2}]);",
						uColumn_Name, uClass_Name + column.Name.ToUpper(), column_idx);
					else if (column.Type == MySqlDbType.Set)
						sb8.AppendFormat(@"
			if (string.Compare(""null"", ret[{2}]) != 0) item.{0} = ({1})long.Parse(ret[{2}]);",
						uColumn_Name, uClass_Name + column.Name.ToUpper(), column_idx);
					else
						sb8.AppendFormat(@"
			if (string.Compare(""null"", ret[{2}]) != 0) item.{0} = {1};",
							uColumn_Name, string.Format(CodeBuild.GetStringifyParse(column.Type), "ret[" + column_idx + "]"), column_idx);
				}

				if (sb2.Length != 0) {
					sb2.Remove(sb2.Length - 2, 2);
					sb3.Remove(sb3.Length - 2, 2);
					sb5.Remove(sb5.Length - 2, 2);
					sb7.Remove(sb7.Length - 6, 6);
				}

				Dictionary<string, string> dic_objs = new Dictionary<string, string>();
				// m -> n
				_tables.ForEach(delegate (TableInfo t2) {
					if (t2.ForeignKeys.Count > 2) {
						foreach(TableInfo t3 in _tables) {
							if (t3.FullName == t2.FullName) continue;
							ForeignKeyInfo fk3 = t3.ForeignKeys.Find(delegate (ForeignKeyInfo ffk3) {
								return ffk3.ReferencedTable.FullName == t2.FullName;
							});
							if (fk3 != null) {
								if (fk3.Columns[0].IsPrimaryKey)
									if (fk3.Table.PrimaryKeys.Count == 1) return; //如果有外键是主键，并且它不是复合组合，则跳过
							}
						}
					}
					ForeignKeyInfo fk_Common = null;
					List<ForeignKeyInfo> fks = t2.ForeignKeys.FindAll(delegate (ForeignKeyInfo ffk) {
						if (ffk.ReferencedTable.FullName == table.FullName/* && 
							ffk.Table.FullName != table.FullName*/) { //注释这行条件为了增加 parent_id 的 obj 对象
							fk_Common = ffk;
							return true;
						}
						return false;
					});
					if (fks.Count == 0) return;
					ForeignKeyInfo fk = fks.Count > 1 ? fks.Find(delegate(ForeignKeyInfo ffk) {
						return string.Compare(table.Name + "_" + table.PrimaryKeys[0].Name, ffk.Columns[0].Name, true) == 0;
					}) : fks[0];
					//if (fk.Table.FullName == table.FullName) return; //注释这行条件为了增加 parent_id 的 obj 对象
					List<ForeignKeyInfo> fk2 = t2.ForeignKeys.FindAll(delegate (ForeignKeyInfo ffk2) {
						return ffk2.Columns[0].IsPrimaryKey && ffk2 != fk;
					});
					// 1 -> 1
					ForeignKeyInfo fk1v1 = table.ForeignKeys.Find(delegate (ForeignKeyInfo ffk2) {
						return ffk2.ReferencedTable.FullName == t2.FullName
							&& ffk2.ReferencedColumns[0].IsPrimaryKey && ffk2.Columns[0].IsPrimaryKey; //这行条件为了增加 parent_id 的 obj 对象
					});
					if (fk1v1 != null) return;

					//t2.Columns
					string t2name = t2.Name;
					string tablename = table.Name;
					string addname = t2name;
					if (t2name.StartsWith(tablename + "_")) {
						addname = t2name.Substring(tablename.Length + 1);
					} else if (t2name.EndsWith("_" + tablename)) {
						addname = t2name.Remove(addname.Length - tablename.Length - 1);
					} else if (fk2.Count == 1 && t2name.EndsWith("_" + tablename)) {
						addname = t2name.Remove(t2name.Length - tablename.Length - 1);
					} else if (fk2.Count == 1 && t2name.EndsWith("_" + fk2[0].ReferencedTable.Name)) {
						addname = t2name;
					}
					string addname_schema = addname == t2.Name && t2.Owner != table.Owner ? t2.ClassName : addname;

					string parms1 = "";
					string parmsNoneType1 = "";
					string parms1_add = "";
					string parmsNoneType1_add = "";
					string parms2 = "";
					string parmsNoneType2 = "";
					string parms2_add = "";
					string parmsNoneType2_add = "";
					string parms3 = "";
					string parmsNoneType3 = "";
					string parms4 = "";
					string parmsNoneType4 = "";
					string parmsNoneType5 = "";
					string pkNamesNoneType = "";
					string updateDiySet = "";
					string add_or_flag = "Add";
					int ms = 0;
					//若中间表，两外键指向相同表，则选择 表名_主键名 此字段作为主参考字段
					string main_column = fk.Columns[0].Name;
					foreach (ColumnInfo columnInfo in t2.Columns) {
						string csType = GetCSType(columnInfo.Type, "");
						bool is_addignore = columnInfo.IsPrimaryKey && csType == "Guid?" ||
							 columnInfo.Name.ToLower() == "update_time" && csType == "DateTime?" ||
							 columnInfo.Name.ToLower() == "create_time" && csType == "DateTime?";
						if (string.Compare(columnInfo.Name, main_column, true) == 0) {
							parmsNoneType2 += string.Format("\r\n			{0} = this.{1}, ", CodeBuild.UFString(columnInfo.Name), CodeBuild.UFString(table.PrimaryKeys[0].Name));
							//if (!is_addignore) parmsNoneType2_add += string.Format("\r\n			{0} = this.{1}, ", CodeBuild.UFString(columnInfo.Name), CodeBuild.UFString(table.PrimaryKeys[0].Name));

							parmsNoneType4 += string.Format(GetCSTypeValue(columnInfo.Type), "this." + CodeBuild.UFString(table.PrimaryKeys[0].Name)) + ", ";
							parmsNoneType5 += string.Format("\r\n			item.{0} = this.{1};", CodeBuild.UFString(columnInfo.Name), CodeBuild.UFString(table.PrimaryKeys[0].Name));
							if (columnInfo.IsPrimaryKey) pkNamesNoneType += string.Format(GetCSTypeValue(table.PrimaryKeys[0].Type), "this." + CodeBuild.UFString(table.PrimaryKeys[0].Name)) + ", ";
							continue;
						}
						if (columnInfo.IsPrimaryKey) pkNamesNoneType += string.Format(GetCSTypeValue(table.PrimaryKeys[0].Type), CodeBuild.UFString(columnInfo.Name)) + ", ";
						else if (columnInfo.Name.ToLower() == "create_time" && csType == "DateTime?") ;
						else updateDiySet += string.Format("\r\n\t\t\t\t\t.Set{0}({0})", CodeBuild.UFString(columnInfo.Name));

						if (columnInfo.IsIdentity) {
							//parmsNoneType2 += "0, ";
							continue;
						}
						parms2 += CodeBuild.GetCSType(columnInfo.Type, CodeBuild.UFString(t2.ClassName) + columnInfo.Name.ToUpper()) + " " + CodeBuild.UFString(columnInfo.Name) + ", ";
						parmsNoneType2 += string.Format("\r\n				{0} = {0}, ", CodeBuild.UFString(columnInfo.Name));
						if (!is_addignore) {
							parms2_add += CodeBuild.GetCSType(columnInfo.Type, CodeBuild.UFString(t2.ClassName) + columnInfo.Name.ToUpper()) + " " + CodeBuild.UFString(columnInfo.Name) + ", ";
							parmsNoneType2_add += string.Format("\r\n				{0} = {0}, ", CodeBuild.UFString(columnInfo.Name));
						}

						ForeignKeyInfo fkk3 = t2.ForeignKeys.Find(delegate (ForeignKeyInfo fkk33) {
							return fkk33.Columns[0].Name == columnInfo.Name;
						});
						if (fkk3 == null) {
							parms1 += CodeBuild.GetCSType(columnInfo.Type, CodeBuild.UFString(t2.ClassName) + columnInfo.Name.ToUpper()) + " " + CodeBuild.UFString(columnInfo.Name) + ", ";
							parmsNoneType1 += CodeBuild.UFString(columnInfo.Name) + ", ";
							if (!is_addignore) {
								parms1_add += CodeBuild.GetCSType(columnInfo.Type, CodeBuild.UFString(t2.ClassName) + columnInfo.Name.ToUpper()) + " " + CodeBuild.UFString(columnInfo.Name) + ", ";
								parmsNoneType1_add += CodeBuild.UFString(columnInfo.Name) + ", ";
							}
						} else {
							string fkk3_ReferencedTable_ObjName = fkk3.ReferencedTable.Name;
							string endStr = "_" + fkk3.ReferencedTable.Name + "_" + fkk3.ReferencedColumns[0].Name;
							if (columnInfo.Name.EndsWith(endStr))
								fkk3_ReferencedTable_ObjName = columnInfo.Name.Remove(columnInfo.Name.Length - fkk3.ReferencedColumns[0].Name.Length - 1);

							fkk3_ReferencedTable_ObjName = CodeBuild.UFString(fkk3_ReferencedTable_ObjName);
							parms1 += CodeBuild.UFString(fkk3.ReferencedTable.ClassName) + "Info " + fkk3_ReferencedTable_ObjName + ", ";
							parmsNoneType1 += fkk3_ReferencedTable_ObjName + "." + CodeBuild.UFString(fkk3.ReferencedColumns[0].Name) + ", ";
							if (!is_addignore) {
								parms1_add += CodeBuild.UFString(fkk3.ReferencedTable.ClassName) + "Info " + fkk3_ReferencedTable_ObjName + ", ";
								parmsNoneType1_add += fkk3_ReferencedTable_ObjName + "." + CodeBuild.UFString(fkk3.ReferencedColumns[0].Name) + ", ";
							}

							if (columnInfo.IsPrimaryKey) {
								parms3 += CodeBuild.UFString(fkk3.ReferencedTable.ClassName) + "Info " + fkk3_ReferencedTable_ObjName + ", ";
								parmsNoneType3 += fkk3_ReferencedTable_ObjName + "." + CodeBuild.UFString(fkk3.ReferencedColumns[0].Name) + ", ";

								parms4 += CodeBuild.GetCSType(columnInfo.Type, CodeBuild.UFString(t2.ClassName) + columnInfo.Name.ToUpper()) + " " + CodeBuild.UFString(columnInfo.Name) + ", ";
								parmsNoneType4 += string.Format(GetCSTypeValue(columnInfo.Type), CodeBuild.UFString(columnInfo.Name)) + ", ";
							}
							if (add_or_flag != "Flag" && fk.Columns[0].IsPrimaryKey) //中间表关系键，必须为主键
								t2.Uniques.ForEach(delegate (List<ColumnInfo> cs) {
									if (cs.Count < 2) return;
									ms = 0;
									foreach (ColumnInfo c in cs) {
										if (t2.ForeignKeys.Find(delegate (ForeignKeyInfo ffkk2) {
											return ffkk2.Columns[0].Name == c.Name;
										}) != null) ms++;
									}
									if (ms == cs.Count) {
										add_or_flag = "Flag";
									}
								});
						}
					}
					if (parms1.Length > 0) parms1 = parms1.Remove(parms1.Length - 2);
					if (parmsNoneType1.Length > 0) parmsNoneType1 = parmsNoneType1.Remove(parmsNoneType1.Length - 2);
					if (parms1_add.Length > 0) parms1_add = parms1_add.Remove(parms1_add.Length - 2);
					if (parmsNoneType1_add.Length > 0) parmsNoneType1_add = parmsNoneType1_add.Remove(parmsNoneType1_add.Length - 2);

					if (parms2.Length > 0) parms2 = parms2.Remove(parms2.Length - 2);
					if (parmsNoneType2.Length > 0) parmsNoneType2 = parmsNoneType2.Remove(parmsNoneType2.Length - 2);
					if (parms2_add.Length > 0) parms2_add = parms2_add.Remove(parms2_add.Length - 2);
					if (parmsNoneType2_add.Length > 0) parmsNoneType2_add = parmsNoneType2_add.Remove(parmsNoneType2_add.Length - 2);

					if (parms3.Length > 0) parms3 = parms3.Remove(parms3.Length - 2);
					if (parmsNoneType3.Length > 0) parmsNoneType3 = parmsNoneType3.Remove(parmsNoneType3.Length - 2);
					if (parms4.Length > 0) parms4 = parms4.Remove(parms4.Length - 2);
					if (parmsNoneType4.Length > 0) parmsNoneType4 = parmsNoneType4.Remove(parmsNoneType4.Length - 2);
					if (pkNamesNoneType.Length > 0) pkNamesNoneType = pkNamesNoneType.Remove(pkNamesNoneType.Length - 2);

					if (add_or_flag == "Flag") {
						if (parms1 != parms2)
							sb6.AppendFormat(@"
		public {0}Info Flag{1}({2}) => Flag{1}({3});", CodeBuild.UFString(t2.ClassName), CodeBuild.UFString(addname_schema), parms1, parmsNoneType1);
						sb6.AppendFormat(@"
		public {0}Info Flag{1}({2}) {{
			{0}Info item = BLL.{0}.GetItem({5});
			if (item == null) item = BLL.{0}.Insert(new {0}Info {{{3}}});{6}
			return item;
		}}
", CodeBuild.UFString(t2.ClassName), CodeBuild.UFString(addname_schema), parms2, parmsNoneType2.Replace("\t\t\t", "\t\t\t\t"), solutionName, pkNamesNoneType, updateDiySet.Length > 0 ? "\r\n\t\t\telse item.UpdateDiy" + updateDiySet + ".ExecuteNonQuery();" : string.Empty);
					} else {
						//sb6.Append(addname + "," + t2.Name);
						if (parms1_add != parms2_add)
							sb6.AppendFormat(@"
		public {0}Info Add{1}({2}) => Add{1}({3});", CodeBuild.UFString(t2.ClassName), CodeBuild.UFString(addname_schema), parms1_add, parmsNoneType1_add);
						sb6.AppendFormat(@"
		public {0}Info Add{1}({2}) => Add{1}(new {0}Info {{{3}}});
		public {0}Info Add{1}({0}Info item) {{{5}
			return item.Save();
		}}
", CodeBuild.UFString(t2.ClassName), CodeBuild.UFString(addname_schema), parms2_add, parmsNoneType2_add, solutionName, parmsNoneType5);
					}

					if (add_or_flag == "Flag") {
						string deleteByUniqui = string.Empty;
						for (int deleteByUniqui_a = 0; deleteByUniqui_a < fk.Table.Uniques.Count; deleteByUniqui_a++)
							if (fk.Table.Uniques[deleteByUniqui_a].Count > 1 && fk.Table.Uniques[deleteByUniqui_a][0].IsPrimaryKey == false) {
								foreach (ColumnInfo deleteByuniquiCol in fk.Table.Uniques[deleteByUniqui_a])
									deleteByUniqui = deleteByUniqui + "And" + CodeBuild.UFString(deleteByuniquiCol.Name);
								deleteByUniqui = "By" + deleteByUniqui.Substring(3);
								break;
							}
						sb6.AppendFormat(@"
		public int Unflag{1}({2}) => Unflag{1}({3});
		public int Unflag{1}({4}) => BLL.{0}.Delete{9}({5});
		public int Unflag{1}ALL() => BLL.{0}.DeleteBy{8}(this.{7});
", CodeBuild.UFString(t2.ClassName), CodeBuild.UFString(addname_schema), parms3, parmsNoneType3, parms4, parmsNoneType4,
	solutionName, CodeBuild.UFString(table.PrimaryKeys[0].Name), CodeBuild.UFString(fk.Columns[0].Name), deleteByUniqui);

						if (ms > 2) {

						} else {
							string civ = string.Format(GetCSTypeValue(table.PrimaryKeys[0].Type), "_" + CodeBuild.UFString(table.PrimaryKeys[0].Name));
							string f5 = t2name;
							//if (addname != f5) {
							string fk20_ReferencedTable_Name = fk2[0].ReferencedTable.Name;
							string fk_ReferencedTable_Name = fk.ReferencedTable.Name;
							if (f5.StartsWith(fk20_ReferencedTable_Name + "_"))
								f5 = f5.Substring(fk20_ReferencedTable_Name.Length + 1);
							else if (f5.EndsWith("_" + fk20_ReferencedTable_Name))
								f5 = f5.Remove(f5.Length - fk20_ReferencedTable_Name.Length - 1);
							else if (string.Compare(t2name, fk20_ReferencedTable_Name + "_" + fk_ReferencedTable_Name) != 0 &&
								string.Compare(t2name, fk_ReferencedTable_Name + "_" + fk20_ReferencedTable_Name) != 0)
								f5 = addname_schema;
							//}
							string objs_value = string.Format(@"
		private List<{0}Info> _obj_{1}s;
		public List<{0}Info> Obj_{1}s => _obj_{1}s ?? (_obj_{1}s = BLL.{0}.SelectBy{5}_{4}({3}).ToList());", CodeBuild.UFString(fk2[0].ReferencedTable.ClassName), CodeBuild.LFString(addname), solutionName, civ, table.PrimaryKeys[0].Name, CodeBuild.UFString(f5));
							//如果中间表字段 > 2，那么应该把其中间表也查询出来
							if (t2.Columns.Count > 2) {
								string _f6 = fk.Columns[0].Name;
								string _f7 = fk.ReferencedTable.PrimaryKeys[0].Name;
								string _f8 = fk2[0].Columns[0].Name;
								string _f9 = GetCSType(fk2[0].ReferencedTable.PrimaryKeys[0].Type, CodeBuild.UFString(fk2[0].ReferencedTable.ClassName) + fk2[0].ReferencedTable.PrimaryKeys[0].Name.ToUpper()).Replace("?", "");

								if (fk.ReferencedTable.ClassName == fk2[0].ReferencedTable.ClassName &&
									string.Compare(main_column, fk.Columns[0].Name, true) != 0) {
									_f6 = fk2[0].Columns[0].Name;
									_f7 = fk2[0].ReferencedTable.PrimaryKeys[0].Name;
									_f8 = fk.Columns[0].Name;
									_f9 = GetCSType(fk2[0].Table.PrimaryKeys[0].Type, CodeBuild.UFString(fk2[0].Table.ClassName) + fk2[0].Table.PrimaryKeys[0].Name.ToUpper()).Replace("?", "");
								}

								objs_value = string.Format(@"
		public {2}Info Obj_{3} {{ set; get; }}
		private List<{0}Info> _obj_{1}s;
		/// <summary>
		/// 遍历时，可通过 Obj_{3} 可获取中间表数据
		/// </summary>
		public List<{0}Info> Obj_{1}s =>_obj_{1}s ?? (_obj_{1}s = BLL.{0}.Select.InnerJoin<BLL.{2}>(""b"", ""b.`{6}` = a.`{5}`"").Where(""b.`{4}` = {{0}}"", {7}).ToList());", CodeBuild.UFString(fk2[0].ReferencedTable.ClassName), CodeBuild.LFString(addname_schema), CodeBuild.UFString(t2.ClassName), CodeBuild.LFString(t2.ClassName),
			_f6, _f7, _f8, civ);
							}
							string objs_key = string.Format("Obj_{0}s", CodeBuild.LFString(addname));
							if (dic_objs.ContainsKey(objs_key))
								dic_objs[objs_key] = objs_value;
							else
								dic_objs.Add(objs_key, objs_value);
						}
					} else {
						string f2 = fk.Columns[0].Name.CompareTo("parent_id") == 0 ? t2name : fk.Columns[0].Name.Replace(tablename + "_" + table.PrimaryKeys[0].Name, "") + CodeBuild.LFString(t2name);
						string objs_value = string.Format(@"
		private List<{0}Info> _obj_{1}s;
		public List<{0}Info> Obj_{1}s => _obj_{1}s ?? (_obj_{1}s = BLL.{0}.SelectBy{3}(_{4}).Limit(500).ToList());", CodeBuild.UFString(t2.ClassName), f2, solutionName, CodeBuild.UFString(fk.Columns[0].Name), CodeBuild.UFString(table.PrimaryKeys[0].Name));
						string objs_key = string.Format("Obj_{0}s", f2);
						if (!dic_objs.ContainsKey(objs_key))
							dic_objs.Add(objs_key, objs_value);
					}
				});
				string[] dic_objs_values = new string[dic_objs.Count];
				dic_objs.Values.CopyTo(dic_objs_values, 0);
				sb9.Append(string.Join("", dic_objs_values));

				string[] innerjoinObjs_values = new string[innerjoinObjs.Count];
				innerjoinObjs.Values.CopyTo(innerjoinObjs_values, 0);
				sb9.Append(string.Join("", innerjoinObjs_values));

				if (table.PrimaryKeys.Count > 0) {
					string newguid = "";
					foreach (ColumnInfo guidpk in table.PrimaryKeys)
						if (GetCSType(guidpk.Type, "") == "Guid?") newguid += string.Format(@"
			this.{0} = Guid.NewGuid();", UFString(guidpk.Name));

					if (table.Columns.Count > table.PrimaryKeys.Count || !string.IsNullOrEmpty(newguid)) {
						ColumnInfo colUpdateTime = table.Columns.Find(delegate (ColumnInfo fcc) { return fcc.Name.ToLower() == "update_time" && GetCSType(fcc.Type, "") == "DateTime?"; });
						ColumnInfo colCreateTime = table.Columns.Find(delegate (ColumnInfo fcc) { return fcc.Name.ToLower() == "create_time" && GetCSType(fcc.Type, "") == "DateTime?"; });
						sb6.Insert(0, string.Format(@"
		public {1}Info Save() {{{2}
			if (this.{4} != null) {{
				BLL.{1}.Update(this);
				return this;
			}}{5}{3}
			return BLL.{1}.Insert(this);
		}}", solutionName, uClass_Name, colUpdateTime != null ? @"
			this." + UFString(colUpdateTime.Name) + " = DateTime.Now;" : "", colCreateTime != null ? @"
			this." + UFString(colCreateTime.Name) + " = DateTime.Now;" : "", pkCsParamNoType.Replace(", ", " != null && this."), newguid));
					}
					sb6.Insert(0, string.Format(@"
		public {0}.DAL.{1}.SqlUpdateBuild UpdateDiy => BLL.{1}.UpdateDiy(this, _{2});", solutionName, uClass_Name, pkCsParamNoTypeByval.Replace(", ", ", _")));
				}

				sb1.AppendFormat(
	@"		#endregion

		public {0}Info() {{ }}", uClass_Name);
				//sb1.AppendFormat(@"
				//
				//		[Obsolete]
				//		public {0}Info({1}) {{
				//{2}		}}", uClass_Name, sb3.ToString(), sb4.ToString());

				sb1.AppendFormat(@"
{1}{2}
		#region 序列化，反序列化
		protected static readonly string StringifySplit = ""@<{0}(Info]?#>"";
		public string Stringify() {{
			return string.Concat({7});
		}}
		public static {0}Info Parse(string stringify) {{
			string[] ret = stringify.Split(new char[] {{ '|' }}, {6}, StringSplitOptions.None);
			if (ret.Length != {6}) throw new Exception(""格式不正确，{0}Info："" + stringify);
			{0}Info item = new {0}Info();{8}
			return item;
		}}
		#endregion

		#region override
		private static Lazy<Dictionary<string, bool>> __jsonIgnoreLazy = new Lazy<Dictionary<string, bool>>(() => {{
			FieldInfo field = typeof({0}Info).GetField(""JsonIgnore"");
			Dictionary<string, bool> ret = new Dictionary<string, bool>();
			if (field != null) string.Concat(field.GetValue(null)).Split(',').ToList().ForEach(f => {{
				if (!string.IsNullOrEmpty(f)) ret[f] = true;
			}});
			return ret;
		}});
		private static Dictionary<string, bool> __jsonIgnore => __jsonIgnoreLazy.Value;
		public override string ToString() {{
			string json = string.Concat({3}, "" }}"");
			return string.Concat(""{{"", json.Substring(1));
		}}
		public IDictionary ToBson(bool allField = false) {{
			IDictionary ht = new Hashtable();{10}
			return ht;
		}}
		public object this[string key] {{
			get {{ return this.GetType().GetProperty(key).GetValue(this); }}
			set {{ this.GetType().GetProperty(key).SetValue(this, value); }}
		}}
		#endregion

		#region properties
{4}{9}
		#endregion
{5}
	}}{11}
}}

", uClass_Name, "", "", sb5.ToString(), sb2.ToString(), sb6.ToString(), table.Columns.Count, sb7.ToString(), sb8.ToString(), sb9.ToString(), sb10.ToString(), sb16.ToString());

				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, solutionName, @".db\Model\", basicName, @"\", uClass_Name, "Info.cs"), Deflate.Compress(Is_System_ComponentModel ? sb1.ToString().Replace("using System.Reflection;", "using System.ComponentModel;\r\nusing System.Reflection;") : sb1.ToString())));
				clearSb();

				Model_Build_ExtensionMethods_cs.AppendFormat(@"
		public static string ToJson(this {0}Info item) {{ return string.Concat(item); }}
		public static string ToJson(this {0}Info[] items) {{ return GetJson(items); }}
		public static string ToJson(this IEnumerable<{0}Info> items) {{ return GetJson(items); }}
		public static IDictionary[] ToBson(this {0}Info[] items, Func<{0}Info, object> func = null) {{ return GetBson(items, func); }}
		public static IDictionary[] ToBson(this IEnumerable<{0}Info> items, Func<{0}Info, object> func = null) {{ return GetBson(items, func); }}
", uClass_Name);
				#endregion

				#region DAL *.cs

				#region use t-sql
				string sqlFields = "";
				string sqlDelete = string.Format("DELETE FROM {0} ", nTable_Name);
				string sqlUpdate = string.Format("UPDATE {0} SET ", nTable_Name);
				string sqlInsert = string.Format("INSERT INTO {0}(", nTable_Name);
				string temp1 = string.Empty;
				string temp2 = string.Empty;
				string temp3 = string.Empty;
				string temp4 = string.Empty;
				ColumnInfo identityColumn = null;
				foreach (ColumnInfo columnInfo in table.Columns) {
					if (columnInfo.IsIdentity == false) {
						temp1 += string.Format("`{0}` = ?{0}, ", columnInfo.Name);
						temp2 += string.Format("`{0}`, ", columnInfo.Name);
						temp3 += string.Format("?{0}, ", columnInfo.Name);
					} else identityColumn = columnInfo;
					temp4 += string.Format("a.`{0}`{1}, ", columnInfo.Name, columnInfo.Type == MySqlDbType.Enum || columnInfo.Type == MySqlDbType.Set ? "+0" : "");
				}
				if (temp1.Length > 0) {
					temp1 = temp1.Substring(0, temp1.Length - 2);
					temp2 = temp2.Substring(0, temp2.Length - 2);
					temp3 = temp3.Substring(0, temp3.Length - 2);
				}
				temp4 = temp4.Substring(0, temp4.Length - 2);
				sqlFields = temp4;
				sqlDelete += "WHERE ";
				sqlUpdate += temp1 + string.Format(" WHERE {0}", pkSqlParam);
				sqlInsert += string.Format("{0}) VALUES({1})", temp2, temp3);
				if (identityColumn != null) sqlInsert += "; SELECT LAST_INSERT_ID();";

				temp1 = "";
				temp2 = "";
				temp3 = "";
				temp4 = "";

				sb1.AppendFormat(
	@"using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using {0}.Model;

namespace {0}.DAL {{

	public partial class {1} : IDAL {{
		#region transact-sql define
		public string Table {{ get {{ return TSQL.Table; }} }}
		public string Field {{ get {{ return TSQL.Field; }} }}
		public string Sort {{ get {{ return TSQL.Sort; }} }}
		internal class TSQL {{
			internal static readonly string Table = ""{3}"";
			internal static readonly string Field = ""{5}"";
			internal static readonly string Sort = ""{6}"";
			public static readonly string Delete = ""DELETE FROM {3} WHERE "";
			public static readonly string Insert = ""{2}{4}"";
		}}
		#endregion

		#region common call
		protected static MySqlParameter GetParameter(string name, MySqlDbType type, int size, object value) {{
			MySqlParameter parm = new MySqlParameter(name, type, size);
			parm.Value = value;
			return parm;
		}}
		protected static MySqlParameter[] GetParameters({1}Info item) {{
			return new MySqlParameter[] {{
{7}}};
		}}", solutionName, uClass_Name, string.Empty, nTable_Name, sqlInsert, sqlFields, orderBy, CodeBuild.AppendParameters(table, "				"));

				sb1.AppendFormat(@"
		public {0}Info GetItem(IDataReader dr) {{
			int index = -1;
			return GetItem(dr, ref index) as {0}Info;
		}}
		public object GetItem(IDataReader dr, ref int index) {{
			{0}Info item = new {0}Info();", uClass_Name);

				foreach (ColumnInfo columnInfo in table.Columns) {
					if (CodeBuild.GetCSType(columnInfo.Type, uClass_Name + columnInfo.Name.ToUpper()) == "byte[]")
						sb1.AppendFormat(@"
				if (!dr.IsDBNull(++index)) item.{0} = dr.GetValue(index) as byte[];", CodeBuild.UFString(columnInfo.Name));
					else if (columnInfo.Type == MySqlDbType.Enum)
						sb1.AppendFormat(@"
				if (!dr.IsDBNull(++index)) item.{0} = ({1}?)dr.GetInt64(index);", CodeBuild.UFString(columnInfo.Name), uClass_Name + columnInfo.Name.ToUpper());
					else if (columnInfo.Type == MySqlDbType.Set)
						sb1.AppendFormat(@"
				if (!dr.IsDBNull(++index)) item.{0} = ({1}?)dr.GetInt64(index);", CodeBuild.UFString(columnInfo.Name), uClass_Name + columnInfo.Name.ToUpper());
					else
						sb1.AppendFormat(@"
				if (!dr.IsDBNull(++index)) item.{0} = {1}dr.{2}(index);", CodeBuild.UFString(columnInfo.Name), CodeBuild.GetDbToCsConvert(columnInfo.Type), CodeBuild.GetDataReaderMethod(columnInfo.Type));
				}
				sb1.AppendFormat(@"
			return item;
		}}");
				sb1.Append(sb4.ToString());
				sb1.AppendFormat(@"
		#endregion", uClass_Name, table.Columns.Count + 1);
				Dictionary<string, bool> del_exists = new Dictionary<string, bool>();
				foreach (List<ColumnInfo> cs in table.Uniques) {
					string parms = string.Empty;
					string parmsBy = "By";
					string sqlParms = string.Empty;
					string sqlParmsA = string.Empty;
					string sqlParmsANoneType = string.Empty;
					int sqlParmsAIndex = 0;
					foreach (ColumnInfo columnInfo in cs) {
						parms += CodeBuild.GetCSType(columnInfo.Type, uClass_Name + columnInfo.Name.ToUpper()).Replace("?", "") + " " + CodeBuild.UFString(columnInfo.Name) + ", ";
						parmsBy += CodeBuild.UFString(columnInfo.Name) + "And";
						sqlParms += "`" + columnInfo.Name + "` = ?" + columnInfo.Name + " AND ";
						sqlParmsA += "a.`" + columnInfo.Name + "` = {" + sqlParmsAIndex++ + "} AND ";
						sqlParmsANoneType += CodeBuild.UFString(columnInfo.Name) + ", ";
					}
					parms = parms.Substring(0, parms.Length - 2);
					parmsBy = parmsBy.Substring(0, parmsBy.Length - 3);
					sqlParms = sqlParms.Substring(0, sqlParms.Length - 5);
					sqlParmsA = sqlParmsA.Substring(0, sqlParmsA.Length - 5);
					sqlParmsANoneType = sqlParmsANoneType.Substring(0, sqlParmsANoneType.Length - 2);
					if (del_exists.ContainsKey(parms)) continue;
					del_exists.Add(parms, true);
					sb2.AppendFormat(@"
		public int Delete{2}({0}) {{
			return SqlHelper.ExecuteNonQuery(string.Concat(TSQL.Delete, ""{1}""), 
{3});
		}}", parms, sqlParms, cs[0].IsPrimaryKey ? string.Empty : parmsBy, CodeBuild.AppendParameters(cs, "				").Replace("?.ToInt64()", ".ToInt64()"));
				}
				table.ForeignKeys.ForEach(delegate (ForeignKeyInfo fkk) {
					string parms = string.Empty;
					string parmsBy = "By";
					string sqlParms = string.Empty;
					foreach (ColumnInfo columnInfo in fkk.Columns) {
						parms += CodeBuild.GetCSType(columnInfo.Type, uClass_Name + columnInfo.Name.ToUpper()) + " " + CodeBuild.UFString(columnInfo.Name) + ", ";
						parmsBy += CodeBuild.UFString(columnInfo.Name) + "And";
						sqlParms += "`" + columnInfo.Name + "` = ?" + columnInfo.Name + " AND ";
					}
					parms = parms.Substring(0, parms.Length - 2);
					parmsBy = parmsBy.Substring(0, parmsBy.Length - 3);
					sqlParms = sqlParms.Substring(0, sqlParms.Length - 5);
					if (del_exists.ContainsKey(parms)) return;
					del_exists.Add(parms, true);

					sb2.AppendFormat(@"
		public int Delete{2}({0}) {{
			return SqlHelper.ExecuteNonQuery(string.Concat(TSQL.Delete, ""{1}""), 
{3});
		}}", parms, sqlParms, parmsBy, CodeBuild.AppendParameters(fkk.Columns, "				"));
				});

				if (table.PrimaryKeys.Count > 0) {
					#region 如果没有主键的处理UpdateBuild
					foreach (ColumnInfo col in table.Columns) {
						if (col.IsIdentity ||
							col.IsPrimaryKey ||
							table.PrimaryKeys.FindIndex(delegate (ColumnInfo pkf) { return pkf.Name == col.Name; }) != -1) continue;
						string lname = CodeBuild.LFString(col.Name);
						string valueParm = CodeBuild.AppendParameters(col, "");
						valueParm = valueParm.Remove(valueParm.LastIndexOf(", ") + 2);
						sb5.AppendFormat(@"
			public SqlUpdateBuild Set{0}({2} value) {{
				if (_item != null) _item.{0} = value;
				return this.Set(""`{1}`"", $""?{1}_{{_parameters.Count}}"", 
					{3}value{4}));
			}}", CodeBuild.UFString(col.Name), col.Name, CodeBuild.GetCSType(col.Type, uClass_Name + col.Name.ToUpper()),
							valueParm.Replace("\"?" + col.Name + "\"", "$\"?" + col.Name + "_{_parameters.Count}\""),
							col.Type == MySqlDbType.Enum || col.Type == MySqlDbType.Set ? "?.ToInt64()" : "");
						if (table.ForeignKeys.FindIndex(delegate (ForeignKeyInfo fkf) { return fkf.Columns.FindIndex(delegate (ColumnInfo fkfpkf) { return fkfpkf.Name == col.Name; }) != -1; }) == -1) {
							string fptype = "";
							string fpset_ = string.Format("_item.{0} += value;", CodeBuild.UFString(col.Name));
							string fparam = valueParm.Replace("\"?" + col.Name + "\"", "$\"?" + col.Name + "_{_parameters.Count}\"");
							if (col.Type == MySqlDbType.Byte || col.Type == MySqlDbType.UByte) {
								fptype = "byte";
								fparam = fparam.Replace("MySqlDbType.UByte", "MySqlDbType.Byte");
							} else if (col.Type == MySqlDbType.Int16 || col.Type == MySqlDbType.UInt16) {
								fptype = "short";
								fparam = fparam.Replace("MySqlDbType.UInt16", "MySqlDbType.Int16");
								if (col.Type == MySqlDbType.UInt16) fpset_ = string.Format("_item.{0} = (ushort?)((short?)_item.{0} + value);", CodeBuild.UFString(col.Name));
							} else if (col.Type == MySqlDbType.Int24 || col.Type == MySqlDbType.UInt24 || col.Type == MySqlDbType.Int32 || col.Type == MySqlDbType.UInt32) {
								fptype = "int";
								fparam = fparam.Replace("MySqlDbType.UInt24", "MySqlDbType.Int32").Replace("MySqlDbType.UInt32", "MySqlDbType.Int32");
								if (col.Type == MySqlDbType.UInt24 || col.Type == MySqlDbType.UInt32) fpset_ = string.Format("_item.{0} = (uint?)((int?)_item.{0} + value);", CodeBuild.UFString(col.Name));
							} else if (col.Type == MySqlDbType.Int64 || col.Type == MySqlDbType.UInt64) {
								fptype = "long";
								fparam = fparam.Replace("MySqlDbType.UInt64", "MySqlDbType.Int64");
								if (col.Type == MySqlDbType.UInt64) fpset_ = string.Format("_item.{0} = (ulong?)((long?)_item.{0} + value);", CodeBuild.UFString(col.Name));
							} else if (col.Type == MySqlDbType.Double || col.Type == MySqlDbType.Float || col.Type == MySqlDbType.Decimal) {
								fptype = CodeBuild.GetCSType(col.Type, uClass_Name + col.Name.ToUpper()).Replace("?", "");
							}
							if ((col.Type == MySqlDbType.UInt32 || col.Type == MySqlDbType.UInt64) && (lname == "status" || lname.StartsWith("status_") || lname.EndsWith("_status"))) {
								fptype = "";
								sb5.AppendFormat(@"
			public SqlUpdateBuild Set{0}Flag(int _0_16, bool isUnFlag = false) {{
				{2} tmp1 = ({2})Math.Pow(2, _0_16);
				if (_item != null) _item.{0} = isUnFlag ? ((_item.{0} ?? 0) ^ tmp1) : ((_item.{0} ?? 0) | tmp1);
				return this.Set(""`{1}`"", $""ifnull(`{1}`,0) {{(isUnFlag ? '^' : '|')}} ?{1}_{{_parameters.Count}}"", 
					{3}tmp1));
			}}
			public SqlUpdateBuild Set{0}UnFlag(int _0_16) {{
				return this.Set{0}Flag(_0_16, true);
			}}", CodeBuild.UFString(col.Name), col.Name, GetCSType(col.Type, uClass_Name + col.Name.ToUpper()).Replace("?", ""), valueParm.Replace("\"?" + col.Name + "\"", "string.Concat(\"?" + col.Name + "_\", _parameters.Count)"));
							}
							if (col.Type == MySqlDbType.Set) {
								fptype = "";
								sb5.AppendFormat(@"
			public SqlUpdateBuild Set{0}Flag({4} value, bool isUnFlag = false) {{
				if (_item != null) _item.{0} = isUnFlag ? ((_item.{0} ?? 0) ^ value) : ((_item.{0} ?? 0) | value);
				return this.Set(""`{1}`"", $""ifnull(`{1}`+0,0) {{(isUnFlag ? '^' : '|')}} ?{1}_{{_parameters.Count}}"", 
					{3}value.ToInt64()));
			}}
			public SqlUpdateBuild Set{0}UnFlag({4} value) {{
				return this.Set{0}Flag(value, true);
			}}", CodeBuild.UFString(col.Name), col.Name, GetCSType(col.Type, uClass_Name + col.Name.ToUpper()).Replace("?", ""), valueParm.Replace("\"?" + col.Name + "\"", "string.Concat(\"?" + col.Name + "_\", _parameters.Count)"), uClass_Name + col.Name.ToUpper());
							}
							if (!string.IsNullOrEmpty(fptype)) {
								sb5.AppendFormat(@"
			public SqlUpdateBuild Set{0}Increment({2} value) {{
				if (_item != null) {4}
				return this.Set(""`{1}`"", $""ifnull(`{1}`, 0) + ?{1}_{{_parameters.Count}}"", 
					{3}value));
			}}", CodeBuild.UFString(col.Name), col.Name, fptype, fparam, fpset_);
							}
						}
						sb6.AppendFormat(@"
				.Set{0}(item.{0})", CodeBuild.UFString(col.Name));
					}

					string dal_insert_code = string.Format(@"
			SqlHelper.ExecuteNonQuery(TSQL.Insert, GetParameters(item));
			return item;", uClass_Name);
					if (identityColumn != null) {
						dal_insert_code = string.Format(@"
			{1} loc1;
			if ({1}.TryParse(string.Concat(SqlHelper.ExecuteScalar(TSQL.Insert, GetParameters(item))), out loc1)) item.{0} = loc1;
			return item;", CodeBuild.UFString(identityColumn.Name), CodeBuild.GetCSType(identityColumn.Type, uClass_Name + identityColumn.Name.ToUpper()).Replace("?", ""));
					}
					sb1.AppendFormat(@"
{1}

		public int Update({0}Info item) {{
			return new SqlUpdateBuild(null, item.{7}){8}.ExecuteNonQuery();
		}}
		#region class SqlUpdateBuild
		public partial class SqlUpdateBuild {{
			protected {0}Info _item;
			protected string _fields;
			protected string _where;
			protected List<MySqlParameter> _parameters = new List<MySqlParameter>();
			public SqlUpdateBuild({0}Info item, {3}) {{
				_item = item;
				_where = SqlHelper.Addslashes(""{4}"", {5});
			}}
			public SqlUpdateBuild() {{ }}
			public override string ToString() {{
				if (string.IsNullOrEmpty(_fields)) return string.Empty;
				if (string.IsNullOrEmpty(_where)) throw new Exception(""防止 {9}.DAL.{0}.SqlUpdateBuild 误修改，请必须设置 where 条件。"");
				return string.Concat(""UPDATE "", TSQL.Table, "" SET "", _fields.Substring(1), "" WHERE "", _where);
			}}
			public int ExecuteNonQuery() {{
				string sql = this.ToString();
				if (string.IsNullOrEmpty(sql)) return 0;
				return SqlHelper.ExecuteNonQuery(sql, _parameters.ToArray());
			}}
			public SqlUpdateBuild Where(string filterFormat, params object[] values) {{
				if (!string.IsNullOrEmpty(_where)) _where = string.Concat(_where, "" AND "");
				_where = string.Concat(_where, ""("", SqlHelper.Addslashes(filterFormat, values), "")"");
				return this;
			}}
			public SqlUpdateBuild WhereExists<T>(SelectBuild<T> select) {{
				return this.Where($""EXISTS({{select.ToString(""1"")}})"");
			}}
			public SqlUpdateBuild WhereNotExists<T>(SelectBuild<T> select) {{
				return this.Where($""NOT EXISTS({{select.ToString(""1"")}})"");
			}}

			public SqlUpdateBuild Set(string field, string value, params MySqlParameter[] parms) {{
				if (value.IndexOf('\'') != -1) throw new Exception(""{9}.DAL.{0}.SqlUpdateBuild 可能存在注入漏洞，不允许传递 ' 给参数 value，若使用正常字符串，请使用参数化传递。"");
				_fields = string.Concat(_fields, "", "", field, "" = "", value);
				if (parms != null && parms.Length > 0) _parameters.AddRange(parms);
				return this;
			}}{6}
		}}
		#endregion

		public {0}Info Insert({0}Info item) {{{10}
		}}
{2}
	}}
}}", uClass_Name, sb2.ToString(), sb3.ToString(), pkCsParam, pkSqlParamFormat, pkCsParamNoType, sb5.ToString(),
	pkCsParamNoTypeByval.Replace(", ", ", item."), sb6.ToString(), solutionName, dal_insert_code);
					#endregion
				} else {
					sb1.AppendFormat(@"
	}}
}}", uClass_Name);
				}
				#endregion

				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, solutionName, @".db\DAL\", basicName, @"\", uClass_Name, ".cs"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion

				#region BLL *.cs
				sb1.AppendFormat(
	@"using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using {0}.Model;

namespace {0}.BLL {{

	public partial class {1} {{

		protected static readonly {0}.DAL.{1} dal = new {0}.DAL.{1}();
		protected static readonly int itemCacheTimeout;

		static {1}() {{
			if (!int.TryParse(RedisHelper.Configuration[""{0}_BLL_ITEM_CACHE:Timeout_{1}""], out itemCacheTimeout))
				int.TryParse(RedisHelper.Configuration[""{0}_BLL_ITEM_CACHE:Timeout""], out itemCacheTimeout);
		}}", solutionName, uClass_Name);

				string removeCacheCode = string.Format(@"
			if (itemCacheTimeout > 0) RemoveCache(GetItem({1}));", uClass_Name, pkCsParamNoType);
				Dictionary<string, bool> del_exists2 = new Dictionary<string, bool>();
				foreach (List<ColumnInfo> cs in table.Uniques) {
					string parms = string.Empty;
					string parmsBy = "By";
					string parmsNoneType = string.Empty;
					string parmsNodeTypeUpdateCacheRemove = string.Empty;
					string cacheCond = string.Empty;
					string cacheRemoveCode = string.Empty;
					string whereCondi = string.Empty;
					foreach (ColumnInfo columnInfo in cs) {
						string getcstype = CodeBuild.GetCSType(columnInfo.Type, uClass_Name + columnInfo.Name.ToUpper());
						parms += getcstype.Replace("?", "") + " " + CodeBuild.UFString(columnInfo.Name) + ", ";
						parmsBy += CodeBuild.UFString(columnInfo.Name) + "And";
						parmsNoneType += CodeBuild.UFString(columnInfo.Name) + ", ";
						parmsNodeTypeUpdateCacheRemove += "item." + CodeBuild.UFString(columnInfo.Name) + ", \"_,_\", ";
						cacheCond += CodeBuild.UFString(columnInfo.Name) + " == null || ";
						whereCondi += string.Format(".Where{0}({1})", CodeBuild.UFString(columnInfo.Name),
							getcstype.Contains("?") && !cs[0].IsPrimaryKey ? string.Concat("new ", getcstype, "(", CodeBuild.UFString(columnInfo.Name), ")") : CodeBuild.UFString(columnInfo.Name));
					}
					parms = parms.Substring(0, parms.Length - 2);
					parmsBy = parmsBy.Substring(0, parmsBy.Length - 3);
					parmsNoneType = parmsNoneType.Substring(0, parmsNoneType.Length - 2);
					parmsNodeTypeUpdateCacheRemove = parmsNodeTypeUpdateCacheRemove.Substring(0, parmsNodeTypeUpdateCacheRemove.Length - 9);
					cacheCond = cacheCond.Substring(0, cacheCond.Length - 4);

					if (del_exists2.ContainsKey(parms)) continue;
					del_exists2.Add(parms, true);
					sb2.AppendFormat(@"
		public static int Delete{2}({0}) {{{3}
			return dal.Delete{2}({1});
		}}", parms, parmsNoneType, cs[0].IsPrimaryKey ? string.Empty : parmsBy, cs[0].IsPrimaryKey ? removeCacheCode : string.Empty);


					sb3.AppendFormat(@"
		public static {1}Info GetItem{2}({4}) {{
			if (itemCacheTimeout <= 0) return Select{7}.ToOne();
			string key = string.Concat(""{0}_BLL_{1}{2}_"", {3});
			string value = RedisHelper.Get(key);
			if (!string.IsNullOrEmpty(value))
				try {{ return {1}Info.Parse(value); }} catch {{ }}
			{1}Info item = Select{7}.ToOne();
			if (item == null) return null;
			RedisHelper.Set(key, item.Stringify(), itemCacheTimeout);
			return item;
		}}", solutionName, uClass_Name, cs[0].IsPrimaryKey ? string.Empty : parmsBy, parmsNodeTypeUpdateCacheRemove.Replace("item.", ""),
		parms, parmsNoneType, cacheCond, whereCondi);

					sb4.AppendFormat(@"
				string.Concat(""{0}_BLL_{1}{2}_"", {3}), ", solutionName, uClass_Name, cs[0].IsPrimaryKey ? string.Empty : parmsBy, parmsNodeTypeUpdateCacheRemove);
				}

				if (table.PrimaryKeys.Count > 0) {
					#region 如果没有主键的处理
					sb2.AppendFormat(@"|deleteby_fk|");

					sb1.AppendFormat(@"

		#region delete, update, insert
{0}
", sb2.ToString());

					sb1.AppendFormat(@"
		public static int Update({1}Info item) {{
			if (itemCacheTimeout > 0) RemoveCache(item);
			return dal.Update(item);
		}}
		public static {0}.DAL.{1}.SqlUpdateBuild UpdateDiy({2}) {{
			return UpdateDiy(null, {3});
		}}
		public static {0}.DAL.{1}.SqlUpdateBuild UpdateDiy({1}Info item, {2}) {{
			if (itemCacheTimeout > 0) RemoveCache(item != null ? item : GetItem({3}));
			return new {0}.DAL.{1}.SqlUpdateBuild(item, {3});
		}}
		/// <summary>
		/// 用于批量更新
		/// </summary>
		public static {0}.DAL.{1}.SqlUpdateBuild UpdateDiyDangerous {{
			get {{ return new {0}.DAL.{1}.SqlUpdateBuild(); }}
		}}
", solutionName, uClass_Name, pkCsParam, pkCsParamNoType);
					if (table.Columns.Count > 5)
						sb1.AppendFormat(@"
		/// <summary>
		/// 适用字段较少的表；避规后续改表风险，字段数较大请改用 {0}.Insert({0}Info item)
		/// </summary>
		[Obsolete]", uClass_Name);
					sb1.AppendFormat(@"
		public static {0}Info Insert({1}) {{
			return Insert(new {0}Info {{{2}}});
		}}", uClass_Name, CsParam2, CsParamNoType2);

					var redisRemove = sb4.ToString();
					if (!string.IsNullOrEmpty(redisRemove)) redisRemove = string.Concat(@"
			RedisHelper.Remove(", redisRemove.Substring(0, redisRemove.Length - 2), ");");
					sb1.AppendFormat(@"
		public static {0}Info Insert({0}Info item) {{
			item = dal.Insert(item);
			if (itemCacheTimeout > 0) RemoveCache(item);
			return item;
		}}
		private static void RemoveCache({0}Info item) {{
			if (item == null) return;{2}
		}}
		#endregion
{1}
", uClass_Name, sb3.ToString(), redisRemove);
					#endregion
				}

				sb1.AppendFormat(@"
		public static List<{0}Info> GetItems() {{
			return Select.ToList();
		}}
		public static {0}SelectBuild Select {{
			get {{ return new {0}SelectBuild(dal); }}
		}}", uClass_Name, solutionName);

				Dictionary<string, bool> byItems = new Dictionary<string, bool>();
				foreach (ForeignKeyInfo fk in table.ForeignKeys) {
					string fkcsBy = string.Empty;
					string fkcsParms = string.Empty;
					string fkcsTypeParms = string.Empty;
					string fkcsFilter = string.Empty;
					int fkcsFilterIdx = 0;
					foreach (ColumnInfo c1 in fk.Columns) {
						fkcsBy += CodeBuild.UFString(c1.Name) + "And";
						fkcsParms += CodeBuild.UFString(c1.Name) + ", ";
						fkcsTypeParms += CodeBuild.GetCSType(c1.Type, uClass_Name + c1.Name.ToUpper()) + " " + CodeBuild.UFString(c1.Name) + ", ";
						fkcsFilter += "a.`" + c1.Name + "` = {" + fkcsFilterIdx++ + "} and ";
					}
					fkcsBy = fkcsBy.Remove(fkcsBy.Length - 3);
					fkcsParms = fkcsParms.Remove(fkcsParms.Length - 2);
					fkcsTypeParms = fkcsTypeParms.Remove(fkcsTypeParms.Length - 2);
					fkcsFilter = fkcsFilter.Remove(fkcsFilter.Length - 4);
					if (byItems.ContainsKey(fkcsBy)) continue;
					byItems.Add(fkcsBy, true);

					if (!del_exists2.ContainsKey(fkcsTypeParms)) {
						sb5.AppendFormat(@"
		public static int DeleteBy{2}({0}) {{
			return dal.DeleteBy{2}({1});
		}}", fkcsTypeParms, fkcsParms, fkcsBy);
						del_exists2.Add(fkcsTypeParms, true);
					}
					if (fk.Columns.Count > 1) {
						sb1.AppendFormat(
		@"
		public static List<{0}Info> GetItemsBy{1}({2}) {{
			return Select.Where{1}({3}).ToList();
		}}
		public static List<{0}Info> GetItemsBy{1}({2}, int limit) {{
			return Select.Where{1}({3}).Limit(limit).ToList();
		}}
		public static {0}SelectBuild SelectBy{1}({2}) {{
			return Select.Where{1}({3});
		}}", uClass_Name, fkcsBy, fkcsTypeParms, fkcsParms);
						sb6.AppendFormat(@"
		public {0}SelectBuild Where{1}({2}) {{
			return base.Where(""{4}"", {3}) as {0}SelectBuild;
		}}", uClass_Name, fkcsBy, fkcsTypeParms, fkcsParms, fkcsFilter, solutionName);
					} else if (fk.Columns.Count == 1/* && fk.Columns[0].IsPrimaryKey == false*/) {
						string csType = CodeBuild.GetCSType(fk.Columns[0].Type, CodeBuild.UFString(fk.Table.ClassName) + fk.Columns[0].Name.ToUpper());
						sb1.AppendFormat(
		@"
		public static List<{0}Info> GetItemsBy{1}(params {2}[] {1}) {{
			return Select.Where{1}({1}).ToList();
		}}
		public static List<{0}Info> GetItemsBy{1}({2}[] {1}, int limit) {{
			return Select.Where{1}({1}).Limit(limit).ToList();
		}}
		public static {0}SelectBuild SelectBy{1}(params {2}[] {1}) {{
			return Select.Where{1}({1});
		}}", uClass_Name, fkcsBy, csType);
						sb6.AppendFormat(@"
		public {0}SelectBuild Where{1}(params {2}[] {1}) {{
			return this.Where1Or(""a.`{3}` = {{0}}"", {1});
		}}
		public {0}SelectBuild Where{1}({4}SelectBuild select) {{
			return this.Where($""a.`{3}` IN ({{select.ToString(""`{5}`"")}})"");
		}}", uClass_Name, fkcsBy, csType, fk.Columns[0].Name, UFString(fk.ReferencedTable.ClassName), fk.ReferencedColumns[0].Name);
					}
				}
				// m -> n
				_tables.ForEach(delegate (TableInfo t2) {
					List<ForeignKeyInfo> fks = t2.ForeignKeys.FindAll(delegate (ForeignKeyInfo ffk) {
						if (ffk.ReferencedTable.FullName == table.FullName) {
							return true;
						}
						return false;
					});
					if (fks.Count == 0) return;
					ForeignKeyInfo fk = fks.Count > 1 ? fks.Find(delegate(ForeignKeyInfo ffk) {
						return string.Compare(table.Name + "_" + table.PrimaryKeys[0].Name, ffk.Columns[0].Name, true) == 0;
					}) : fks[0];
					//if (fk.Table.FullName == table.FullName) return;
					List<ForeignKeyInfo> fk2 = t2.ForeignKeys.FindAll(delegate (ForeignKeyInfo ffk2) {
						return ffk2.Columns[0].IsPrimaryKey && ffk2 != fk;
					});
					if (fk2.Count != 1) return;
					if (fk.Columns[0].IsPrimaryKey == false) return; //中间表关系键，必须为主键

					//t2.Columns
					string t2name = t2.Name;
					string tablename = table.Name;
					string addname = t2name;
					if (t2name.StartsWith(tablename + "_")) {
						addname = t2name.Substring(tablename.Length + 1);
					} else if (t2name.EndsWith("_" + tablename)) {
						addname = t2name.Remove(addname.Length - tablename.Length - 1);
					} else if (fk2.Count == 1 && t2name.EndsWith("_" + tablename)) {
						addname = t2name.Remove(t2name.Length - tablename.Length - 1);
					} else if (fk2.Count == 1 && t2name.EndsWith("_" + fk2[0].ReferencedTable.Name)) {
						addname = t2name;
					}
					string addname_schema = addname == t2.Name && t2.Owner != table.Owner ? t2.ClassName : addname;

					string orgInfo = CodeBuild.UFString(fk2[0].ReferencedTable.ClassName);
					string fkcsBy = CodeBuild.UFString(addname_schema);
					if (byItems.ContainsKey(fkcsBy)) return;
					byItems.Add(fkcsBy, true);

					string civ = string.Format(GetCSTypeValue(fk2[0].ReferencedTable.PrimaryKeys[0].Type), CodeBuild.UFString(fk2[0].ReferencedTable.PrimaryKeys[0].Name));
					sb1.AppendFormat(@"
		public static {0}SelectBuild SelectBy{1}(params {2}Info[] {5}s) {{
			return Select.Where{1}({5}s);
		}}
		public static {0}SelectBuild SelectBy{1}_{4}(params {3}[] {5}_ids) {{
			return Select.Where{1}_{4}({5}_ids);
		}}", uClass_Name, fkcsBy, orgInfo,
		GetCSType(fk2[0].ReferencedTable.PrimaryKeys[0].Type, CodeBuild.UFString(fk2[0].ReferencedTable.ClassName) + fk2[0].ReferencedTable.PrimaryKeys[0].Name.ToUpper()).Replace("?", ""), 
		table.PrimaryKeys[0].Name, LFString(orgInfo));

					string _f6 = fk.Columns[0].Name;
					string _f7 = fk.ReferencedTable.PrimaryKeys[0].Name;
					string _f8 = fk2[0].Columns[0].Name;
					string _f9 = GetCSType(fk2[0].ReferencedTable.PrimaryKeys[0].Type, CodeBuild.UFString(fk2[0].ReferencedTable.ClassName) + fk2[0].ReferencedTable.PrimaryKeys[0].Name.ToUpper()).Replace("?", "");

					//若中间表，两外键指向相同表，则选择 表名_主键名 此字段作为主参考字段
					string main_column = fk.Columns[0].Name;
					if (fk.ReferencedTable.ClassName == fk2[0].ReferencedTable.ClassName &&
						string.Compare(main_column, fk.Columns[0].Name, true) == 0) {
						_f6 = fk2[0].Columns[0].Name;
						_f7 = fk2[0].ReferencedTable.PrimaryKeys[0].Name;
						_f8 = fk.Columns[0].Name;
						_f9 = GetCSType(fk2[0].Table.PrimaryKeys[0].Type, CodeBuild.UFString(fk2[0].Table.ClassName) + fk2[0].Table.PrimaryKeys[0].Name.ToUpper()).Replace("?", "");
					}
					sb6.AppendFormat(@"
		public {0}SelectBuild Where{1}(params {2}Info[] {10}s) => Where{1}({10}s?.ToArray(), null);
		public {0}SelectBuild Where{1}_{7}(params {9}[] {10}_ids) => Where{1}_{7}({10}_ids?.ToArray(), null);
		public {0}SelectBuild Where{1}({2}Info[] {10}s, Action<{5}SelectBuild> subCondition) => Where{1}_{7}({10}s?.Where<{2}Info>(a => a != null).Select<{2}Info, {9}>(a => a.{3}).ToArray(), subCondition);
		public {0}SelectBuild Where{1}_{7}({9}[] {10}_ids, Action<{5}SelectBuild> subCondition) {{
			if ({10}_ids == null || {10}_ids.Length == 0) return this;
			{5}SelectBuild subConditionSelect = {5}.Select.Where(string.Format(""`{6}` = a . `{7}` AND `{8}` IN ('{{0}}')"", string.Join(""','"", {10}_ids.Select(a => string.Concat(a).Replace(""'"", ""''"")))));
			if (subCondition != null) subCondition(subConditionSelect);
			var subConditionSql = subConditionSelect.ToString(""`{6}`"").Replace("" a \r\nWHERE ("", "" WHERE "");
			if (subCondition != null) subConditionSql = subConditionSql.Replace(""a.`"", ""`{12}`.`"");
			return base.Where($""EXISTS({{subConditionSql}})"") as {0}SelectBuild;
		}}", uClass_Name, fkcsBy, orgInfo, civ, string.Empty, CodeBuild.UFString(t2.ClassName), _f6, _f7, _f8, _f9, LFString(orgInfo), t2.Owner, t2.Name);
				});

				table.Columns.ForEach(delegate (ColumnInfo col) {
					string csType = CodeBuild.GetCSType(col.Type, uClass_Name + col.Name.ToUpper());
					string lname = col.Name.ToLower();
					//if (col.IsPrimaryKey) return;
					//if (lname == "create_time" ||
					//	lname == "update_time") return;
					string fkcsBy = CodeBuild.UFString(col.Name);
					if (byItems.ContainsKey(fkcsBy)) return;
					byItems.Add(fkcsBy, true);

					if (csType == "bool?" || csType == "Guid?") {
						sb6.AppendFormat(@"
		public {0}SelectBuild Where{1}(params {2}[] {1}) {{
			return this.Where1Or(""a.`{3}` = {{0}}"", {1});
		}}", uClass_Name, fkcsBy, col.IsPrimaryKey ? csType.Replace("?", "") : csType, col.Name);
						return;
					}
					if (col.Type == MySqlDbType.Byte || col.Type == MySqlDbType.Int16 || col.Type == MySqlDbType.Int24 || col.Type == MySqlDbType.Int32 || col.Type == MySqlDbType.Int64 ||
						col.Type == MySqlDbType.UByte || col.Type == MySqlDbType.UInt16 || col.Type == MySqlDbType.UInt24 || col.Type == MySqlDbType.UInt32 || col.Type == MySqlDbType.UInt64 ||
						col.Type == MySqlDbType.Year) {
						sb6.AppendFormat(@"
		public {0}SelectBuild Where{1}(params {2}[] {1}) {{
			return this.Where1Or(""a.`{3}` = {{0}}"", {1});
		}}", uClass_Name, fkcsBy, col.IsPrimaryKey ? csType.Replace("?", "") : csType, col.Name);
						return;
					}
					if (col.Type == MySqlDbType.Double || col.Type == MySqlDbType.Float || col.Type == MySqlDbType.Decimal) {
						sb6.AppendFormat(@"
		public {0}SelectBuild Where{1}(params {2}[] {1}) {{
			return this.Where1Or(""a.`{3}` = {{0}}"", {1});
		}}", uClass_Name, fkcsBy, csType, col.Name);
						sb6.AppendFormat(@"
		public {0}SelectBuild Where{1}Range({2} begin) {{
			return base.Where(""a.`{3}` >= {{0}}"", begin) as {0}SelectBuild;
		}}
		public {0}SelectBuild Where{1}Range({2} begin, {2} end) {{
			if (end == null) return Where{1}Range(begin);
			return base.Where(""a.`{3}` between {{0}} and {{1}}"", begin, end) as {0}SelectBuild;
		}}", uClass_Name, fkcsBy, csType, col.Name);
						return;
					}
					if (col.Type == MySqlDbType.Date || col.Type == MySqlDbType.Time || col.Type == MySqlDbType.Timestamp || col.Type == MySqlDbType.Datetime) {
						if (col.IsPrimaryKey)
							sb6.AppendFormat(@"
		public {0}SelectBuild Where{1}({2} {1}) {{
			return base.Where(""a.`{3}` = {{0}}"", {1}) as {0}SelectBuild;
		}}", uClass_Name, fkcsBy, csType, col.Name);
						sb6.AppendFormat(@"
		public {0}SelectBuild Where{1}Range({2} begin) {{
			return base.Where(""a.`{3}` >= {{0}}"", begin) as {0}SelectBuild;
		}}
		public {0}SelectBuild Where{1}Range({2} begin, {2} end) {{
			if (end == null) return Where{1}Range(begin);
			return base.Where(""a.`{3}` between {{0}} and {{1}}"", begin, end) as {0}SelectBuild;
		}}", uClass_Name, fkcsBy, csType, col.Name);
						return;
					}
					if ((col.Type == MySqlDbType.UInt32 || col.Type == MySqlDbType.UInt64) && (lname == "status" || lname.StartsWith("status_") || lname.EndsWith("_status"))) {
						sb6.AppendFormat(@"
		public {0}SelectBuild Where{1}(params int[] _0_16) {{
			if (_0_16 == null || _0_16.Length == 0) return this;
			{2}[] copy = new {2}[_0_16.Length];
			for (int a = 0; a < _0_16.Length; a++) copy[a] = ({2})Math.Pow(2, _0_16[a]);
			return this.Where1Or(""(a.`{3}` & {{0}}) = {{0}}"", copy);
		}}", uClass_Name, fkcsBy, csType.Replace("?", ""), col.Name);
						return;
					}
					if (col.Type == MySqlDbType.Set) {
						sb6.AppendFormat(@"
		public {0}SelectBuild Where{1}_IN(params {2}[] {1}s) {{
			return this.Where1Or(""(a.`{3}` & {{0}}) = {{0}}"", {1}s);
		}}
		public {0}SelectBuild Where{1}({2} {1}1) {{
			return this.Where{1}_IN({1}1);
		}}
		#region Where{1}
		public {0}SelectBuild Where{1}({2} {1}1, {2} {1}2) {{
			return this.Where{1}_IN({1}1, {1}2);
		}}
		public {0}SelectBuild Where{1}({2} {1}1, {2} {1}2, {2} {1}3) {{
			return this.Where{1}_IN({1}1, {1}2, {1}3);
		}}
		public {0}SelectBuild Where{1}({2} {1}1, {2} {1}2, {2} {1}3, {2} {1}4) {{
			return this.Where{1}_IN({1}1, {1}2, {1}3, {1}4);
		}}
		public {0}SelectBuild Where{1}({2} {1}1, {2} {1}2, {2} {1}3, {2} {1}4, {2} {1}5) {{
			return this.Where{1}_IN({1}1, {1}2, {1}3, {1}4, {1}5);
		}}
		#endregion", uClass_Name, fkcsBy, csType.Replace("?", ""), col.Name);
						return;
					}
					if (col.Type == MySqlDbType.Enum) {
						sb6.AppendFormat(@"
		public {0}SelectBuild Where{1}_IN(params {2}?[] {1}s) {{
			return this.Where1Or(""a.`{3}` = {{0}}"", {1}s);
		}}
		public {0}SelectBuild Where{1}({2} {1}1) {{
			return this.Where{1}_IN({1}1);
		}}
		#region Where{1}
		public {0}SelectBuild Where{1}({2} {1}1, {2} {1}2) {{
			return this.Where{1}_IN({1}1, {1}2);
		}}
		public {0}SelectBuild Where{1}({2} {1}1, {2} {1}2, {2} {1}3) {{
			return this.Where{1}_IN({1}1, {1}2, {1}3);
		}}
		public {0}SelectBuild Where{1}({2} {1}1, {2} {1}2, {2} {1}3, {2} {1}4) {{
			return this.Where{1}_IN({1}1, {1}2, {1}3, {1}4);
		}}
		public {0}SelectBuild Where{1}({2} {1}1, {2} {1}2, {2} {1}3, {2} {1}4, {2} {1}5) {{
			return this.Where{1}_IN({1}1, {1}2, {1}3, {1}4, {1}5);
		}}
		#endregion", uClass_Name, fkcsBy, csType.Replace("?", ""), col.Name);
						return;
					}
					if (csType == "string") {
						if (col.Length > 0 && col.Length < 301)
							sb6.AppendFormat(@"
		public {0}SelectBuild Where{1}(params {2}[] {1}) {{
			return this.Where1Or(""a.`{3}` = {{0}}"", {1});
		}}", uClass_Name, fkcsBy, csType, col.Name);
						sb6.AppendFormat(@"
		public {0}SelectBuild Where{1}Like(params {2}[] {1}) {{
			if ({1} == null || {1}.Where(a => !string.IsNullOrEmpty(a)).Any() == false) return this;
			return this.Where1Or(@""a.`{3}` LIKE {{0}}"", {1}.Select(a => ""%"" + a + ""%"").ToArray());
		}}", uClass_Name, fkcsBy, csType, col.Name);
						return;
					}
				});

				sb1.AppendFormat(@"
	}}
	public partial class {0}SelectBuild : SelectBuild<{0}Info, {0}SelectBuild> {{{2}
		protected new {0}SelectBuild Where1Or(string filterFormat, Array values) {{
			return base.Where1Or(filterFormat, values) as {0}SelectBuild;
		}}
		public {0}SelectBuild(IDAL dal) : base(dal, SqlHelper.Instance) {{ }}
	}}
}}", uClass_Name, solutionName, sb6.ToString());

				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, solutionName, @".db\BLL\", basicName, @"\", uClass_Name, ".cs"), Deflate.Compress(sb1.ToString().Replace("|deleteby_fk|", sb5.ToString()))));
				clearSb();
				#endregion

				if (table.PrimaryKeys.Count == 0) continue;

				#region admin
				if (isMakeAdmin) {

					#region common define
					string pkNames = string.Empty;
					string pkUrlQuerys = string.Empty;
					string pkHiddens = string.Empty;
					for (int a = 0; a < table.PrimaryKeys.Count; a++) {
						ColumnInfo col88 = table.PrimaryKeys[a];
						pkNames += CodeBuild.UFString(col88.Name) + ",";
						pkUrlQuerys += string.Format(@"{0}=@item.{0}&", CodeBuild.UFString(col88.Name));
						pkHiddens += string.Format(@"@item.{0},", CodeBuild.UFString(col88.Name));
					}
					if (pkNames.Length > 0) pkNames = pkNames.Remove(pkNames.Length - 1);
					if (pkUrlQuerys.Length > 0) pkUrlQuerys = pkUrlQuerys.Remove(pkUrlQuerys.Length - 1);
					if (pkHiddens.Length > 0) pkHiddens = pkHiddens.Remove(pkHiddens.Length - 1);

					ForeignKeyInfo ttfk = table.ForeignKeys.Find(delegate (ForeignKeyInfo fkk) {
						return fkk.ReferencedTable != null && fkk.ReferencedTable.FullName == table.FullName;
					});
					#endregion

					#region wwwroot_sitemap
					wwwroot_sitemap += string.Format(@"
			<li><a href=""/{0}/""><i class=""fa fa-circle-o""></i>{0}</a></li>", uClass_Name);
					#endregion

					#region init_sysdir
					admin_controllers_syscontroller_init_sysdir.Add(string.Format(@"

			dir2 = Sysdir.Insert(dir1.Id, DateTime.Now, ""{0}"", {1}, ""/{0}/"");
			dir3 = Sysdir.Insert(dir2.Id, DateTime.Now, ""列表"", 1, ""/{0}/"");
			dir3 = Sysdir.Insert(dir2.Id, DateTime.Now, ""添加"", 2, ""/{0}/add"");
			dir3 = Sysdir.Insert(dir2.Id, DateTime.Now, ""编辑"", 3, ""/{0}/edit"");
			dir3 = Sysdir.Insert(dir2.Id, DateTime.Now, ""删除"", 4, ""/{0}/del"");", nClass_Name, admin_controllers_syscontroller_init_sysdir.Count + 1));
					#endregion

					#region Controller.cs
					string str_listTh = "";
					string str_listTd = "";
					string str_listTh1 = "";
					string str_listTd1 = "";
					string str_controller_list_join = "";
					byte str_controller_list_join_alias = 97;
					string str_listCms2FilterFK = "";
					string str_listCms2FilterFK_fkitems = "";
					string keyLikes = string.Empty;
					string getListParamQuery = "";
					bool ttfk_flag = false;
					string str_addhtml_mn = "";
					string str_controller_insert_mn = "";
					string str_controller_update_mn = "";
					string str_fk_getlist = "";
					string str_addjs_mn_initUI = "";
					foreach (ColumnInfo col in table.Columns) {
						List<ColumnInfo> us = table.Uniques.Find(delegate (List<ColumnInfo> cs) {
							return cs.Find(delegate (ColumnInfo col88) {
								return col88.Name == col.Name;
							}) != null;
						});
						if (us == null) us = new List<ColumnInfo>();
						List<ForeignKeyInfo> fks_comb = table.ForeignKeys.FindAll(delegate (ForeignKeyInfo fk2) {
							return fk2.Columns.Count == 1 && fk2.Columns[0].Name == col.Name;
						});

						string csType = CodeBuild.GetCSType(col.Type, uClass_Name + col.Name.ToUpper());
						string csUName = CodeBuild.UFString(col.Name);
						string comment = _column_coments[table.FullName][col.Name];
						if (csType == "string") {
							keyLikes += "a." + col.Name + " like {0} or ";
						}
						List<ForeignKeyInfo> fks = table.ForeignKeys.FindAll(delegate (ForeignKeyInfo fk88) {
							return fk88.Columns.Find(delegate (ColumnInfo col88) {
								return col88.Name == col.Name;
							}) != null;
						});

						//外键
						ForeignKeyInfo fk = null;
						string FK_uEntry_Name = string.Empty;
						string tableNamefe3 = string.Empty;
						string memberName = string.Empty;
						string strName = string.Empty;
						if (fks.Count > 0) {
							fk = fks[0];
							FK_uEntry_Name = fk.ReferencedTable != null ? CodeBuild.GetCSName(fk.ReferencedTable.Name) :
								CodeBuild.GetCSName(TableInfo.GetEntryName(fk.ReferencedTableName));
							tableNamefe3 = fk.ReferencedTable != null ? fk.ReferencedTable.Name : FK_uEntry_Name;
							memberName = fk.Columns[0].Name.IndexOf(tableNamefe3) == -1 ? CodeBuild.LFString(tableNamefe3) :
								(CodeBuild.LFString(fk.Columns[0].Name.Substring(0, fk.Columns[0].Name.IndexOf(tableNamefe3)) + tableNamefe3));
							if (fk.Columns[0].Name.IndexOf(tableNamefe3) == 0 && fk.ReferencedTable != null) memberName = CodeBuild.LFString(fk.ReferencedTable.ClassName);

							ColumnInfo strNameCol = null;
							if (fk.ReferencedTable != null) {
								strNameCol = fk.ReferencedTable.Columns.Find(delegate (ColumnInfo col88) {
									return col88.Name.ToLower().IndexOf("name") != -1 || col88.Name.ToLower().IndexOf("title") != -1;
								});
								if (strNameCol == null) strNameCol = fk.ReferencedTable.Columns.Find(delegate (ColumnInfo col88) {
									return GetCSType(col88.Type, CodeBuild.UFString(fk.ReferencedTable.ClassName) + col88.Name.ToUpper()) == "string" && col88.Length > 0 && col88.Length < 300;
								});
							}
							strName = strNameCol != null ? "." + CodeBuild.UFString(strNameCol.Name) : string.Empty;
						}
						string Obj_name = string.Concat("Obj_", memberName, strName);

						if (!col.IsIdentity && fks.Count == 1) {
							ForeignKeyInfo fkcb = fks[0];
							string FK_uClass_Name = fkcb.ReferencedTable != null ? CodeBuild.UFString(fkcb.ReferencedTable.ClassName) :
								CodeBuild.UFString(TableInfo.GetClassName(fkcb.ReferencedTableName));

							getListParamQuery += string.Format(@"[FromQuery] {0}[] {1}, ", csType, csUName);
							sb3.AppendFormat(@"
			if ({0}.Length > 0) select.Where{0}({0});", csUName);
						} else if (!col.IsIdentity && us.Count == 1 || col.IsPrimaryKey && table.PrimaryKeys.Count == 1) {
							//主键或唯一键，非自动增值
						}

						//前端js或者模板
						if (!col.IsIdentity && fks.Count == 1 && fks[0].Table.FullName != fks[0].ReferencedTable.FullName) {
							str_listTh += string.Format(@"<th scope=""col"">{0}</th>
						", comment);
							str_listTd += string.Format(@"<td>[@item.{0}] @item.Obj_{1}{2}</td>
								", csUName, memberName, string.IsNullOrEmpty(strName) ? "" : ("?" + strName));
							str_controller_list_join += string.Format(@"
				.LeftJoin<{0}>(""{3}"", ""{3}.{1} = a.{2}"")", CodeBuild.UFString(fks[0].ReferencedTable.ClassName), fks[0].ReferencedColumns[0].Name, fks[0].Columns[0].Name, (char)++str_controller_list_join_alias);
							if (str_listCms2FilterFK_fkitems.Contains("	var fk_" + CodeBuild.LFString(fks[0].ReferencedTable.ClassName) + "s = ") == false)
								str_listCms2FilterFK_fkitems += string.Format(@"
	var fk_{1}s = {0}.Select.ToList();", CodeBuild.UFString(fks[0].ReferencedTable.ClassName), CodeBuild.LFString(fks[0].ReferencedTable.ClassName));
							str_listCms2FilterFK += string.Format(@"
			{{ name: '{0}', field: '{4}', text: @Html.Json(fk_{1}s.Select(a => a.{2})), value: @Html.Json(fk_{1}s.Select(a => a.{3})) }},",
				CodeBuild.UFString(fks[0].ReferencedTable.ClassName), CodeBuild.LFString(fks[0].ReferencedTable.ClassName),
				string.IsNullOrEmpty(strName) ? "ToString()" : strName.TrimStart('.'), CodeBuild.UFString(fks[0].ReferencedColumns[0].Name), CodeBuild.UFString(fks[0].Columns[0].Name));
						} else if (csType == "string" && !ttfk_flag) {
							ttfk_flag = true;
							string t1 = string.Format(@"<th scope=""col"">{0}</th>
						", comment);
							string t2 = string.Format(@"<td>@item.{0}</td>
								", csUName);
							str_listTh1 += t1;
							str_listTd1 += t2;
							if (ttfk == null || ttfk.Columns[0].Name.ToLower() != "parent_id") {
								str_listTh += t1;
								str_listTd += t2;
							}
						} else {
							str_listTh += string.Format(@"<th scope=""col"">{0}</th>
						", comment);
							str_listTd += string.Format(@"<td>@item.{0}</td>
								", csUName);
						}
					}
					if (keyLikes.Length > 0) {
						keyLikes = keyLikes.Remove(keyLikes.Length - 4);
						getListParamQuery = "[FromQuery] string key, " + getListParamQuery;
						sb2.AppendFormat(@"
				.Where(!string.IsNullOrEmpty(key), ""{0}"", string.Concat(""%"", key, ""%""))", keyLikes);
					}

					string itemSetValuePK = "";
					string itemSetValuePKInsert = "";
					string itemSetValueNotPK = "";
					string itemCsParamInsertForm = "";
					string itemCsParamUpdateForm = "";
					table.Columns.ForEach(delegate (ColumnInfo col88) {
						string csLName = CodeBuild.LFString(col88.Name);
						string csUName = CodeBuild.UFString(col88.Name);
						string csType = CodeBuild.GetCSType(col88.Type, uClass_Name + col88.Name.ToUpper());

						if (col88.IsPrimaryKey) {
			//				itemSetValuePK += string.Format(@"
			//item.{0} = {0};", csUName);
							if (col88.IsIdentity) ;
							else {
								itemSetValuePKInsert += string.Format(@"
			item.{0} = {0};", csUName);
								itemCsParamInsertForm += string.Format(", [FromForm] {0} {1}", csType, csUName);
							}
						} else if (col88.IsIdentity) {
						} else if ((csLName == "img" || csLName.StartsWith("img_") || csLName.EndsWith("_img") ||
							csLName == "path" || csLName.StartsWith("path_") || csLName.EndsWith("_path")) && (col88.Type == MySqlDbType.VarChar || col88.Type == MySqlDbType.VarString || col88.Type == MySqlDbType.String)) {
							//图片字段
							itemCsParamInsertForm += string.Format(", [FromForm] {0} {1}, [FromForm] IFormFile {1}_file", csType, csUName);
							itemCsParamUpdateForm += string.Format(", [FromForm] {0} {1}, [FromForm] IFormFile {1}_file", csType, csUName);
							itemSetValuePKInsert += string.Format(@"
			if ({1}_file != null) {{
				item.{1} = $""/upload/{{Guid.NewGuid().ToString()}}.png"";
				using (FileStream fs = new FileStream(System.IO.Path.Combine(AppContext.BaseDirectory, item.{1}), FileMode.Create)) {1}_file.CopyTo(fs);
			}} else
				item.{1} = {1};", "", csUName);
							itemSetValuePK += string.Format(@"
			if (!string.IsNullOrEmpty(item.{1}) && (item.{1} != {1} || {1}_file != null)) {{
				string path = System.IO.Path.Combine(AppContext.BaseDirectory, item.{1});
				if (System.IO.File.Exists(path)) System.IO.File.Delete(path);
			}}
			if ({1}_file != null) {{
				item.{1} = $""/upload/{{Guid.NewGuid().ToString()}}.png"";
				using (FileStream fs = new FileStream(System.IO.Path.Combine(AppContext.BaseDirectory, item.{1}), FileMode.Create)) {1}_file.CopyTo(fs);
			}} else
				item.{1} = {1};", "", csUName);
						} else {
							string colvalue = "";
							if (csType == "DateTime?" && (
	   string.Compare(csLName, "create_time", true) == 0 ||
	   string.Compare(csLName, "update_time", true) == 0
   )) {
								colvalue = "DateTime.Now";
							} else {
								string csType2 = csType;
								if (col88.Type == MySqlDbType.Set) csType2 = csType2.Replace("?", "[]");
								itemCsParamInsertForm += string.Format(", [FromForm] {0} {1}", csType2, csUName);
								itemCsParamUpdateForm += string.Format(", [FromForm] {0} {1}", csType2, csUName);
								colvalue = csUName;
							}
							if (col88.Type == MySqlDbType.Set)
								itemSetValueNotPK += string.Format(@"
			item.{0} = null;
			{0}?.ToList().ForEach(a => item.{0} = (item.{0} ?? 0) | a);", csUName);
							else
								itemSetValueNotPK += string.Format(@"
			item.{0} = {1};", csUName, colvalue);
						}
					});
					if (itemCsParamInsertForm.Length > 0) itemCsParamInsertForm = itemCsParamInsertForm.Substring(2);

					// m -> n
					_tables.ForEach(delegate (TableInfo t2) {
						ForeignKeyInfo fk = t2.ForeignKeys.Find(delegate (ForeignKeyInfo ffk) {
							if (ffk.ReferencedTable.FullName == table.FullName) {
								return true;
							}
							return false;
						});
						if (fk == null) return;
						if (fk.Table.FullName == table.FullName) return;
						List<ForeignKeyInfo> fk2 = t2.ForeignKeys.FindAll(delegate (ForeignKeyInfo ffk2) {
							return ffk2 != fk;
						});
						if (fk2.Count != 1) return;
						if (fk.Columns[0].IsPrimaryKey == false) return; //中间表关系键，必须为主键
						if (t2.Columns.Count != 2) return; //mn表若不是两个字段，则不处理

						//t2.Columns
						string t2name = t2.Name;
						string tablename = table.Name;
						string addname = t2name;
						if (t2name.StartsWith(tablename + "_")) {
							addname = t2name.Substring(tablename.Length + 1);
						} else if (t2name.EndsWith("_" + tablename)) {
							addname = t2name.Remove(addname.Length - tablename.Length - 1);
						} else if (fk2.Count == 1 && t2name.EndsWith("_" + tablename)) {
							addname = t2name.Remove(t2name.Length - tablename.Length - 1);
						} else if (fk2.Count == 1 && t2name.EndsWith("_" + fk2[0].ReferencedTable.Name)) {
							addname = t2name;
						}

						ColumnInfo strNameCol = fk2[0].ReferencedTable.Columns.Find(delegate (ColumnInfo col88) {
							return col88.Name.ToLower().IndexOf("name") != -1 || col88.Name.ToLower().IndexOf("title") != -1;
						});
						if (strNameCol == null) strNameCol = fk2[0].ReferencedTable.Columns.Find(delegate (ColumnInfo col88) {
							return GetCSType(col88.Type, CodeBuild.UFString(fk2[0].ReferencedTable.ClassName) + col88.Name.ToUpper()) == "string" && col88.Length > 0 && col88.Length < 300;
						});
						if (strNameCol == null) strNameCol = fk2[0].ReferencedTable.PrimaryKeys[0];
						string strName = CodeBuild.UFString(strNameCol.Name);

						getListParamQuery += string.Format(@"[FromQuery] {0}[] {1}_{2}, ", GetCSType(fk2[0].ReferencedTable.PrimaryKeys[0].Type, CodeBuild.UFString(fk2[0].ReferencedTable.ClassName) + fk2[0].ReferencedTable.PrimaryKeys[0].Name.ToUpper()).Replace("?", ""), CodeBuild.UFString(addname), table.PrimaryKeys[0].Name);
						sb3.AppendFormat(@"
			if ({0}_{1}.Length > 0) select.Where{0}_{1}({0}_{1});", CodeBuild.UFString(addname), table.PrimaryKeys[0].Name);
						if (str_listCms2FilterFK_fkitems.Contains("	var fk_" + CodeBuild.LFString(fk2[0].ReferencedTable.ClassName) + "s = ") == false)
							str_listCms2FilterFK_fkitems += string.Format(@"
	var fk_{1}s = {0}.Select.ToList();", CodeBuild.UFString(fk2[0].ReferencedTable.ClassName), CodeBuild.LFString(fk2[0].ReferencedTable.ClassName));
						str_listCms2FilterFK += string.Format(@"
			{{ name: '{0}', field: '{4}', text: @Html.Json(fk_{1}s.Select(a => a.{2})), value: @Html.Json(fk_{1}s.Select(a => a.{3})) }},",
			CodeBuild.UFString(fk2[0].ReferencedTable.ClassName), CodeBuild.LFString(fk2[0].ReferencedTable.ClassName),
			string.IsNullOrEmpty(strName) ? "ToString()" : strName.TrimStart('.'), CodeBuild.UFString(fk2[0].ReferencedColumns[0].Name), CodeBuild.UFString(fk2[0].Columns[0].Name));
						//add.html 标签关联
						itemCsParamInsertForm += string.Format(", [FromForm] {0}[] mn_{1}", CodeBuild.GetCSType(fk2[0].ReferencedColumns[0].Type, CodeBuild.UFString(fk2[0].ReferencedTable.ClassName) + fk2[0].ReferencedColumns[0].Name.ToUpper()).Replace("?", ""), CodeBuild.UFString(addname));
						itemCsParamUpdateForm += string.Format(", [FromForm] {0}[] mn_{1}", CodeBuild.GetCSType(fk2[0].ReferencedColumns[0].Type, CodeBuild.UFString(fk2[0].ReferencedTable.ClassName) + fk2[0].ReferencedColumns[0].Name.ToUpper()).Replace("?", ""), CodeBuild.UFString(addname));
						str_controller_insert_mn += string.Format(@"
			//关联 {1}
			foreach ({0} mn_{1}_in in mn_{1})
				item.Flag{1}(mn_{1}_in);", CodeBuild.GetCSType(fk2[0].ReferencedColumns[0].Type, CodeBuild.UFString(fk2[0].ReferencedTable.ClassName) + fk2[0].ReferencedColumns[0].Name.ToUpper()).Replace("?", ""), CodeBuild.UFString(addname));
						str_controller_update_mn += string.Format(@"
			//关联 {1}
			if (mn_{1}.Length == 0) {{
				item.Unflag{1}ALL();
			}} else {{
				List<{0}> mn_{1}_list = mn_{1}.ToList();
				foreach (var Obj_{2} in item.Obj_{2}s) {{
					int idx = mn_{1}_list.FindIndex(a => a == Obj_{2}.Id);
					if (idx == -1) item.Unflag{1}(Obj_{2}.Id);
					else mn_{1}_list.RemoveAt(idx);
				}}
				mn_{1}_list.ForEach(a => item.Flag{1}(a));
			}}", CodeBuild.GetCSType(fk2[0].ReferencedColumns[0].Type, CodeBuild.UFString(fk2[0].ReferencedTable.ClassName) + fk2[0].ReferencedColumns[0].Name.ToUpper()).Replace("?", ""), CodeBuild.UFString(addname), addname);
						str_addhtml_mn += string.Format(@"
						<tr>
							<td>{1}</td>
							<td>
								<select name=""mn_{2}"" data-placeholder=""Select a {3}"" class=""form-control select2"" multiple>
									@foreach ({0}Info fk in fk_{1}s) {{ <option value=""@fk.{4}"">@fk.{5}</option> }}
								</select>
							</td>
						</tr>", CodeBuild.UFString(fk2[0].ReferencedTable.ClassName), CodeBuild.LFString(fk2[0].ReferencedTable.ClassName),
							CodeBuild.UFString(addname), CodeBuild.LFString(addname), CodeBuild.UFString(fk2[0].ReferencedColumns[0].Name), strName);
						if (str_fk_getlist.Contains("	var fk_" + CodeBuild.LFString(fk2[0].ReferencedTable.ClassName) + "s") == false)
							str_fk_getlist += string.Format(@"
	var fk_{1}s = {0}.Select.ToList();", CodeBuild.UFString(fk2[0].ReferencedTable.ClassName), CodeBuild.LFString(fk2[0].ReferencedTable.ClassName));
						str_addjs_mn_initUI += string.Format(@"
			item.mn_{0} = @Html.Json(item.Obj_{2}s);
			for (var a = 0; a < item.mn_{0}.length; a++) $(form.mn_{0}).find('option[value=""{{0}}""]'.format(item.mn_{0}[a].{1})).attr('selected', 'selected');", CodeBuild.UFString(addname), CodeBuild.UFString(fk2[0].ReferencedColumns[0].Name), CodeBuild.LFString(addname));
					});

					string str_mvcdel = string.Format(@"
		public APIReturn _Del([FromForm] {2}[] ids) {{
			int affrows = 0;
			foreach ({2} id in ids)
				affrows += {1}.Delete(id);
			if (affrows > 0) return APIReturn.成功.SetMessage($""删除成功，影响行数：{{affrows}}"");
			return APIReturn.失败;
		}}", solutionName, uClass_Name, CodeBuild.GetCSType(table.PrimaryKeys[0].Type, CodeBuild.UFString(table.ClassName) + table.PrimaryKeys[0].Name.ToUpper()).Replace("?", ""));
					if (table.PrimaryKeys.Count > 1) {
						string pkParses = "";
						int pk_idx = 0;
						foreach (ColumnInfo pk in table.PrimaryKeys) {
							pkParses += ", " + string.Format(GetStringifyParse(pk.Type).Replace(".Replace(StringifySplit, \"|\")", ""), "vs[" + pk_idx++ + "]");
						}
						pkParses = pkParses.Substring(2);
						str_mvcdel = string.Format(@"
		public APIReturn _Del([FromForm] string[] ids) {{
			int affrows = 0;
			foreach (string id in ids) {{
				string[] vs = id.Split(',');
				affrows += {1}.Delete({2});
			}}
			if (affrows > 0) return APIReturn.成功.SetMessage($""删除成功，影响行数：{{affrows}}"");
			return APIReturn.失败;
		}}", solutionName, uClass_Name, pkParses);
					}

					sb1.AppendFormat(CONST.Module_Admin_Controller, solutionName, uClass_Name, nClass_Name, pkMvcRoute,
						"[FromQuery] " + pkCsParam.Replace("?", "").Replace(", ", ", [FromQuery] "), pkCsParamNoType, itemSetValuePK, itemSetValueNotPK,
						sb2.ToString(), sb3.ToString(), itemCsParamInsertForm, itemCsParamUpdateForm, getListParamQuery, itemSetValuePKInsert,
						str_controller_list_join, "",
						str_controller_insert_mn, str_controller_update_mn, str_mvcdel);

					loc1.Add(new BuildInfo(string.Concat(CONST.moduleAdminPath, @"\Controllers\", uClass_Name, @"Controller.cs"), Deflate.Compress(sb1.ToString())));
					clearSb();
					#endregion

					if (ttfk == null || ttfk.Columns[0].Name.ToLower() != "parent_id") {
						#region wwwroot/xxx/index.html
						foreach (ColumnInfo col in table.Columns) {
							List<ForeignKeyInfo> ffks = new List<ForeignKeyInfo>();
							foreach (TableInfo fti in _tables) {
								ffks.AddRange(fti.ForeignKeys.FindAll(delegate (ForeignKeyInfo ffk) {
									if (ffk.ReferencedTable != null && ffk.ReferencedTable.FullName == table.FullName) {
										return ffk.ReferencedColumns.Find(delegate (ColumnInfo col88) {
											return col88.Name == col.Name;
										}) != null;
									}
									return false;
								}));
							}
							foreach (ForeignKeyInfo ffk in ffks) {
								string FFK_uClass_Name = CodeBuild.UFString(ffk.Table.ClassName);
								string FFK_nClass_Name = CodeBuild.UFString(ffk.Table.ClassName);

								string urlQuerys = string.Empty;
								ffk.Columns.ForEach(delegate (ColumnInfo col88) {
									string FFK_csUName = CodeBuild.UFString(col.Name);
									urlQuerys += string.Format("{0}=@item.{1}&", CodeBuild.UFString(col88.Name), FFK_csUName);
								});
								if (urlQuerys.Length > 0) urlQuerys = urlQuerys.Remove(urlQuerys.Length - 1);

								str_listTh += string.Format(@"<th scope=""col"">&nbsp;</th>
						");
								str_listTd += string.Format(@"<td><a href=""../{0}/?{1}"">{0}</a></td>
							", FFK_nClass_Name, urlQuerys);
							}
						}
						sb1.AppendFormat(@"@{{ 
	Layout = """";
}}

<div class=""box"">
	<div class=""box-header with-border"">
		<h3 id=""box-title"" class=""box-title""></h3>
		<span class=""form-group mr15""></span><a href=""./add"" data-toggle=""modal"" class=""btn btn-success pull-right"">添加</a>
	</div>
	<div class=""box-body"">
		<div class=""table-responsive"">
			<form id=""form_search"">
				<div id=""div_filter""></div>
			</form>
			<form id=""form_list"" action=""./del"" method=""post"">
				@Html.AntiForgeryToken()
				<input type=""hidden"" name=""__callback"" value=""del_callback""/>
				<table id=""GridView1"" cellspacing=""0"" rules=""all"" border=""1"" style=""border-collapse:collapse;"" class=""table table-bordered table-hover"">
					<tr>
						<th scope=""col"" style=""width:2%;""><input type=""checkbox"" onclick=""$('#GridView1 tbody tr').each(function (idx, el) {{ var chk = $(el).find('td:first input[type=\'checkbox\']')[0]; if (chk) chk.checked = !chk.checked; }});"" /></th>
						{3}<th scope=""col"" style=""width:5%;"">&nbsp;</th>
					</tr>
					<tbody>
						@foreach({0}Info item in ViewBag.items) {{
							<tr>
								<td><input type=""checkbox"" id=""id"" name=""id"" value=""{2}"" /></td>
								{4}<td><a href=""./edit?{1}"">修改</a></td>
							</tr>
						}}
					</tbody>
				</table>
			</form>
			<a id=""btn_delete_sel"" href=""#"" class=""btn btn-danger pull-right"">删除选中项</a>
			<div id=""kkpager""></div>
		</div>
	</div>
</div>

@{{{6}
}}
<script type=""text/javascript"">
	(function () {{
		top.del_callback = function(rt) {{
			if (rt.success) return top.mainViewNav.goto('./');
			alert(rt.message);
		}};

		var qs = _clone(top.mainViewNav.query);
		var page = cint(qs.page, 1);
		delete qs.page;
		$('#kkpager').html(cms2Pager(@ViewBag.count, page, 20, qs, 'page'));
		var fqs = _clone(top.mainViewNav.query);
		delete fqs.page;
		var fsc = [{5}
			null
		];
		fsc.pop();
		cms2Filter(fsc, fqs);
		top.mainViewInit();
	}})();
</script>
", uClass_Name, pkUrlQuerys, pkHiddens, str_listTh, str_listTd, str_listCms2FilterFK, str_listCms2FilterFK_fkitems);
						loc1.Add(new BuildInfo(string.Concat(CONST.moduleAdminPath, @"Views\", uClass_Name, @"\List.cshtml"), Deflate.Compress(sb1.ToString())));
						clearSb();
						#endregion
					} else {
						#region wwwroot/xxx/index.html(递归关系)
						sb1.AppendFormat(@"@{{ 
	Layout = """";
}}

<div class=""box"">
	<div class=""box-header with-border"">
		<h3 id=""box-title"" class=""box-title""></h3>
		<span class=""form-group mr15""></span><a href=""./add"" data-toggle=""modal"" class=""btn btn-success pull-right"">添加</a>
	</div>
	<div class=""box-body"">
		<div class=""table-responsive"">
			<form id=""form_list"" action=""./del"" method=""post"">
				@Html.AntiForgeryToken()
				<input type=""hidden"" name=""__callback"" value=""del_callback""/>
				<table id=""GridView1"" cellspacing=""0"" rules=""all"" border=""1"" style=""border-collapse:collapse;"" class=""table table-bordered table-hover"">
					<tr>
						{8}{6}<th scope=""col"" style=""width:5%;"">&nbsp;</th>
						<th scope=""col"" style=""width:5%;"">删除</th>
					</tr>
					<tbody>
						@foreach({0}Info item in ViewBag.items) {{
							<tr data-tt-id=""@item.{1}"" data-tt-parent-id=""@item.{2}"">
								{9}{7}<td><a href=""./edit?{4}"">修改</a></td>
								<td><input id=""id"" name=""id"" type=""checkbox"" value=""{5}"" /></td>
							</tr>
						}}
					</tbody>
				</table>
			</form>
		</div>
	</div>
</div>

<div>
	<font color=""red"">*</font> 删除父项时，请先删除其所有子项。
	<a id=""btn_delete_sel"" href=""#"" class=""btn btn-danger pull-right"">删除选中项</a>
</div>

<script type=""text/javascript"">
	(function() {{
		top.del_callback = function(rt) {{
			if (rt.success) return top.mainViewNav.goto('./');
			alert(rt.message);
		}};

		$('table#GridView1').treetable({{ expandable: true }});
		$('table#GridView1').treetable('expandAll');
		top.mainViewInit();
	}})();
</script>", uClass_Name, CodeBuild.UFString(table.PrimaryKeys[0].Name), CodeBuild.UFString(ttfk.Columns[0].Name), "",
	pkUrlQuerys.Replace("a.", ""), pkHiddens.Replace("a.", ""), str_listTh.Replace("a.", ""), str_listTd.Replace("a.", ""), str_listTh1.Replace("a.", ""), str_listTd1.Replace("a.", ""));
						loc1.Add(new BuildInfo(string.Concat(CONST.moduleAdminPath, @"Views\", uClass_Name, @"\List.cshtml"), Deflate.Compress(sb1.ToString())));
						clearSb();
						#endregion
					}

					#region wwwroot/xxx/add.html
					foreach (ColumnInfo col in table.Columns) {
						string csType = CodeBuild.GetCSType(col.Type, uClass_Name + col.Name.ToUpper());
						string csUName = CodeBuild.UFString(col.Name);
						string lname = col.Name.ToLower();
						string comment = _column_coments[table.FullName][col.Name];
						string rfvEmpty = string.Empty;
						List<ColumnInfo> us = table.Uniques.Find(delegate (List<ColumnInfo> cs) {
							return cs.Find(delegate (ColumnInfo col88) {
								return col88.Name == col.Name;
							}) != null;
						});
						if (us == null) us = new List<ColumnInfo>();
						List<ForeignKeyInfo> fks_comb = table.ForeignKeys.FindAll(delegate (ForeignKeyInfo fk) {
							return fk.Columns.Count == 1 && fk.Columns[0].Name == col.Name;
						});

						if (csType == "bool?") {
							sb4.AppendFormat(@"
						<tr>
							<td>{1}</td>
							<td id=""{0}_td""><input name=""{0}"" type=""checkbox"" value=""true"" /></td>
						</tr>", csUName, comment);
						} else if (csType == "DateTime?" && (
							string.Compare(lname, "create_time", true) == 0 ||
							string.Compare(lname, "update_time", true) == 0
							)) {
							sb14.AppendFormat(@"
							<tr>
								<td>{1}</td>
								<td><input name=""{0}"" type=""text"" readonly class=""datepicker"" style=""width:20%;background-color:#ddd;"" /></td>
							</tr>", csUName, comment);
						} else if (col.IsPrimaryKey && col.IsIdentity) {
							//主键自动增值
							sb4.AppendFormat(@"
						@if (item != null) {{
							<tr>
								<td>{1}</td>
								<td><input name=""{0}"" type=""text"" readonly class=""datepicker"" style=""width:20%;background-color:#ddd;"" /></td>
							</tr>
						}}", csUName, comment);
						} else if (fks_comb.Count == 1) {
							//外键下拉框
							ForeignKeyInfo fkcb = fks_comb[0];
							string FK_uClass_Name = fkcb.ReferencedTable != null ? CodeBuild.UFString(fkcb.ReferencedTable.ClassName) :
								CodeBuild.UFString(TableInfo.GetClassName(fkcb.ReferencedTableName));
							ForeignKeyInfo fkrr = fkcb.ReferencedTable != null ?
										fkcb.ReferencedTable.ForeignKeys.Find(delegate (ForeignKeyInfo fkkk) {
											return fkkk.ReferencedTable != null && fkcb.ReferencedTable.FullName == fkkk.ReferencedTable.FullName;
										}) : null;
							bool isParentSelect = fkcb.ReferencedTable != null && fkrr != null;
							string FK_Column = fkcb.ReferencedTable != null ?
										CodeBuild.UFString(fkcb.ReferencedColumns[0].Name) : CodeBuild.UFString(fkcb.ReferencedColumnNames[0]);

							ColumnInfo strCol = fkcb.ReferencedTable.Columns.Find(delegate (ColumnInfo col99) {
								return col99.Name.ToLower().IndexOf("name") != -1 || col99.Name.ToLower().IndexOf("title") != -1;
							});
							if (strCol == null) strCol = fkcb.ReferencedTable.Columns.Find(delegate (ColumnInfo col99) {
								return GetCSType(col99.Type, CodeBuild.UFString(fkcb.ReferencedTable.ClassName) + col99.Name.ToUpper()) == "string" && col99.Length > 0 && col99.Length < 300;
							});
							string FK_Column_Text = fkcb.ReferencedTable != null && strCol != null ? CodeBuild.UFString(strCol.Name)
								 : FK_Column;

							if (isParentSelect) {
								sb4.AppendFormat(@"
						<tr>
							<td>{1}</td>
							<td id=""{0}_td""></td>
						</tr>", csUName, comment);
								sb5.AppendFormat(@"
		$('#{3}_td').html(yieldTreeSelect(yieldTreeArray(@Html.Json(fk_{0}s), null, '{1}', '{2}'), '{{#{4}}}', '{1}')).find('select').attr('name', '{3}');",
			FK_uClass_Name, CodeBuild.UFString(fkcb.ReferencedColumns[0].Name), CodeBuild.UFString(fkrr.Columns[0].Name), csUName, FK_Column_Text);
							} else {
								sb4.AppendFormat(@"
						<tr>
							<td>{1}</td>
							<td>
								<select name=""{0}"">
									<option value="""">------ 请选择 ------</option>
									@foreach (var fk in fk_{4}s) {{ <option value=""@fk.{2}"">@fk.{3}</option> }}
								</select>
							</td>
						</tr>", csUName, comment, CodeBuild.UFString(fkcb.ReferencedColumns[0].Name), FK_Column_Text, FK_uClass_Name);
							}
							if (str_fk_getlist.Contains("	var fk_" + FK_uClass_Name + "s") == false)
								str_fk_getlist += string.Format(@"
	var fk_{0}s = {0}.Select.ToList();", FK_uClass_Name);
						} else if ((col.Type == MySqlDbType.UInt32 || col.Type == MySqlDbType.UInt64) && (lname == "status" || lname.StartsWith("status_") || lname.EndsWith("_status"))) {
							//加载 multi 多状态字段
							sb4.AppendFormat(@"
						<tr>
							<td>{1}</td>
							<td><input name=""{0}"" type=""hidden"" multi_status=""状态1,状态2,状态3,状态4,状态5"" /></td>
						</tr>", csUName, comment);
						} else if (
							col.Type == MySqlDbType.Byte || col.Type == MySqlDbType.Int16 || col.Type == MySqlDbType.Int24 || col.Type == MySqlDbType.Int32 || col.Type == MySqlDbType.Int64 ||
							col.Type == MySqlDbType.UByte || col.Type == MySqlDbType.UInt16 || col.Type == MySqlDbType.UInt24 || col.Type == MySqlDbType.UInt32 || col.Type == MySqlDbType.UInt64 ||
							col.Type == MySqlDbType.Year) {
							sb4.AppendFormat(@"
						<tr>
							<td>{1}</td>
							<td><input name=""{0}"" type=""text"" class=""form-control"" data-inputmask=""'mask': '9', 'repeat': 6, 'greedy': false"" data-mask style=""width:200px;"" /></td>
						</tr>", csUName, comment);
						} else if (col.Type == MySqlDbType.Double || col.Type == MySqlDbType.Float || col.Type == MySqlDbType.Decimal) {
							sb4.AppendFormat(@"
						<tr>
							<td>{1}</td>
							<td>
								<div class=""input-group"" style=""width:200px;"">
									<span class=""input-group-addon"">￥</span>
									<input name=""{0}"" type=""text"" class=""form-control"" data-inputmask=""'mask': '9', 'repeat': 10, 'greedy': false"" data-mask />
									<span class=""input-group-addon"">.00</span>
								</div>
							</td>
						</tr>", csUName, comment);
						} else if (col.Type == MySqlDbType.Date || col.Type == MySqlDbType.Time || col.Type == MySqlDbType.Timestamp || col.Type == MySqlDbType.Datetime) {
							//日期
							sb4.AppendFormat(@"
						<tr>
							<td>{1}</td>
							<td><input name=""{0}"" type=""text"" class=""datepicker"" /></td>
						</tr>", csUName, comment);
						} else if (col.Type == MySqlDbType.Date) {
							//日期控件
							sb4.AppendFormat(@"
						<tr>
							<td>{1}</td>
							<td>
								<div class=""input-group date"" style=""width:200px;"">
									<div class=""input-group-addon""><i class=""fa fa-calendar""></i></div>
									<input name=""{0}"" type=""text"" data-provide=""datepicker"" class=""form-control pull-right"" readonly />
								</div>
							</td>
						</tr>", csUName, comment);
						} else if ((lname == "img" || lname.StartsWith("img_") || lname.EndsWith("_img") ||
							lname == "path" || lname.StartsWith("path_") || lname.EndsWith("_path")) && (col.Type == MySqlDbType.VarChar || col.Type == MySqlDbType.VarString || col.Type == MySqlDbType.String)) {
							//图片字段
							sb4.AppendFormat(@"
						<tr>
							<td>{1}</td>
							<td>
								<input name=""{0}"" type=""text"" class=""datepicker"" style=""width:60%;"" />
								<input name=""{0}_file"" type=""file"">
							</td>
						</tr>", csUName, comment);
						} else if (col.Type == MySqlDbType.TinyText || col.Type == MySqlDbType.Text || col.Type == MySqlDbType.MediumText || col.Type == MySqlDbType.LongText) {
							//加载百度编辑器
							sb4.AppendFormat(@"
						<tr>
							<td>{1}</td>
							<td><textarea name=""{0}"" style=""width:100%;height:100px;"" editor=""ueditor""></textarea></td>
						</tr>", csUName, comment);
						} else if (col.Type == MySqlDbType.Enum || col.Type == MySqlDbType.Set) {
							sb4.AppendFormat(@"
						<tr>
							<td>{1}</td>
							<td>
								<select name=""{0}""{3}
									@foreach (object eo in Enum.GetValues(typeof({2}))) {{ <option value=""@eo"">@eo</option> }}
								</select>
							</td>
						</tr>", csUName, comment, GetCSType(col.Type, CodeBuild.UFString(table.ClassName) + col.Name.ToUpper()).Replace("?", ""), col.Type == MySqlDbType.Set ? string.Format(@" data-placeholder=""Select a {0}"" class=""form-control select2"" multiple>", comment) : @"><option value="""">------ 请选择 ------</option>");
						} else {
							sb4.AppendFormat(@"
						<tr>
							<td>{1}</td>
							<td><input name=""{0}"" type=""text"" class=""datepicker"" style=""width:60%;"" /></td>
						</tr>", csUName, comment);
						}
					}
					sb4.Append(str_addhtml_mn);
					if (sb14.ToString().Length > 0) {
						sb14.Insert(0, @"
						@if (item != null) {");
						sb14.Append(@"
						}");
					}

					sb1.AppendFormat(@"@{{
	Layout = """";
	{0}Info item = ViewBag.item;{3}
}}

<div class=""box"">
	<div class=""box-header with-border"">
		<h3 class=""box-title"" id=""box-title""></h3>
	</div>
	<div class=""box-body"">
		<div class=""table-responsive"">
			<form id=""form_add"" method=""post"">
				@Html.AntiForgeryToken()
				<input type=""hidden"" name=""__callback"" value=""edit_callback"" />
				<div>
					<table cellspacing=""0"" rules=""all"" class=""table table-bordered table-hover"" border=""1"" style=""border-collapse:collapse;"">{1}{5}
						<tr>
							<td width=""8%"">&nbsp</td>
							<td><input type=""submit"" value=""@(item == null ? ""添加"" : ""更新"")"" />&nbsp;<input type=""button"" value=""取消"" /></td>
						</tr>
					</table>
				</div>
			</form>

		</div>
	</div>
</div>

<script type=""text/javascript"">
	(function () {{
		top.edit_callback = function (rt) {{
			if (rt.success) return top.mainViewNav.goto('./');
			alert(rt.message);
		}};
{2}
		var form = $('#form_add')[0];
		var item = null;
		@if (item != null) {{
			<text>
			item = @Html.Json(item);
			fillForm(form, item);{4}
			</text>
		}}
		top.mainViewInit();
	}})();
</script>", uClass_Name, sb4.ToString(), sb5.ToString(), str_fk_getlist, str_addjs_mn_initUI, sb14.ToString());
					loc1.Add(new BuildInfo(string.Concat(CONST.moduleAdminPath, @"Views\", uClass_Name, @"\Edit.cshtml"), Deflate.Compress(sb1.ToString())));
					clearSb();
					#endregion
				}
				#endregion
			}

			#region BLL ItemCache.cs
			sb1.AppendFormat(CONST.BLL_Build_ItemCache_cs, solutionName);
			//loc1.Add(new BuildInfo(string.Concat(CONST.corePath, solutionName, @".db\BLL\", basicName, @"\ItemCache.cs"), Deflate.Compress(sb1.ToString())));
			clearSb();
			#endregion
			#region BLL RedisHelper.cs
			sb1.AppendFormat(CONST.BLL_Build_RedisHelper_cs, solutionName);
			loc1.Add(new BuildInfo(string.Concat(CONST.corePath, solutionName, @".db\BLL\", basicName, @"\RedisHelper.cs"), Deflate.Compress(sb1.ToString())));
			clearSb();
			#endregion
			#region Model ExtensionMethods.cs 扩展方法
			sb1.AppendFormat(CONST.Model_Build_ExtensionMethods_cs, solutionName, Model_Build_ExtensionMethods_cs.ToString());
			loc1.Add(new BuildInfo(string.Concat(CONST.corePath, solutionName, @".db\Model\", basicName, @"\ExtensionMethods.cs"), Deflate.Compress(sb1.ToString())));
			clearSb();
			#endregion
			#region DBUtility/SqlHelper.cs
			sb1.AppendFormat(CONST.DAL_DBUtility_SqlHelper_cs, solutionName, connectionStringName);
			loc1.Add(new BuildInfo(string.Concat(CONST.corePath, solutionName, @".db\DAL\DBUtility\SqlHelper.cs"), Deflate.Compress(sb1.ToString())));
			clearSb();
			#endregion

			if (isSolution) {
				#region db.csproj
				sb1.AppendFormat(CONST.Db_csproj, solutionName);
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, solutionName, @".db\", solutionName, ".db.csproj"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion

				#region Module/Test
				#region TestController.cs
				sb1.AppendFormat(CONST.Module_Test_Controller, solutionName, "Test");
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Module\Test\Controllers\TestController.cs"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region appsettings.json
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Module\Test\appsettings.json"), Deflate.Compress("{\r\n}")));
				clearSb();
				#endregion

				#region Views\_ViewStart.cshtml
				sb1.AppendFormat(@"@{{
	Layout = ""_Layout"";
}}", solutionName);
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Module\Test\Views\_ViewStart.cshtml"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region Views\_ViewImports.cshtml
				sb1.AppendFormat(@"@using Newtonsoft.Json;
@using {0}.BLL;
@using {0}.Model;

@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
", solutionName);
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Module\Test\Views\_ViewImports.cshtml"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region Views\Shared\_Layout.cshtml
				sb1.AppendFormat(@"<!DOCTYPE html>
<html>
<head>
	<meta charset=""utf-8"">
	<title>@ViewBag.title</title>
	<link rel=""stylesheet"" href=""//cdn.bootcss.com/semantic-ui/2.1.8/semantic.min.css"">
	<link rel=""stylesheet"" href=""/css/style.css"">
	<script src=""//cdn.bootcss.com/jquery/1.11.3/jquery.min.js""></script>
	<script src=""//cdn.bootcss.com/semantic-ui/2.1.8/semantic.min.js""></script>
</head>
<body>

	@RenderBody()

</body>
</html>", solutionName);
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Module\Test\Views\Shared\_Layout.cshtml"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region Test.csproj
				sb1.AppendFormat(CONST.Module_csproj, "Test");
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"Module\Test\Test.csproj"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#endregion

				#region .gitattributes
				sb1.Append(Server.Properties.Resources._gitattributes);
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"..\.gitattributes"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region .gitignore
				sb1.Append(Server.Properties.Resources._gitignore);
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"..\.gitignore"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region build.bat
				sb1.Append(Server.Properties.Resources._build_bat);
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"..\build.bat"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region readme.md
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"..\readme.md"), Deflate.Compress(string.Format(@"# {0}
.net core模块化开发架构", solutionName))));
				clearSb();
				#endregion
			}

			if (isMakeAdmin) {
				#region WebHost
				#region Extensions/StarupExtensions.cs
				sb1.AppendFormat(CONST.WebHost_Extensions_StarupExtensions_cs, solutionName);
				loc1.Add(new BuildInfo(string.Concat(CONST.webHostPath, @"\Extensions\StarupExtensions.cs"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region Extensions/SwaggerExtensions.cs
				sb1.AppendFormat(CONST.WebHost_Extensions_SwaggerExtensions_cs, solutionName);
				loc1.Add(new BuildInfo(string.Concat(CONST.webHostPath, @"\Extensions\SwaggerExtensions.cs"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region .gitignore
				sb1.Append(Server.Properties.Resources.WebHost_gitignore);
				loc1.Add(new BuildInfo(string.Concat(CONST.webHostPath, @".gitignore"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region appsettings.json
				sb1.AppendFormat(CONST.WebHost_appsettings_json, solutionName);
				loc1.Add(new BuildInfo(string.Concat(CONST.webHostPath, @"appsettings.json"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region gulpfile.js
				sb1.Append(Server.Properties.Resources.WebHost_gulpfile_js);
				loc1.Add(new BuildInfo(string.Concat(CONST.webHostPath, @"gulpfile.js"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region nlog.config
				sb1.AppendFormat(CONST.WebHost_nlog_config, solutionName);
				loc1.Add(new BuildInfo(string.Concat(CONST.webHostPath, @"nlog.config"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region package.json
				sb1.Append(Server.Properties.Resources.WebHost_package_json);
				loc1.Add(new BuildInfo(string.Concat(CONST.webHostPath, @"package.json"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region Program.cs
				sb1.AppendFormat(CONST.WebHost_Program_cs, solutionName);
				loc1.Add(new BuildInfo(string.Concat(CONST.webHostPath, @"Program.cs"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region Startup.cs
				sb1.AppendFormat(CONST.WebHost_Startup_cs, solutionName);
				loc1.Add(new BuildInfo(string.Concat(CONST.webHostPath, @"Startup.cs"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region web.config
				sb1.Append(Server.Properties.Resources.WebHost_web_config);
				loc1.Add(new BuildInfo(string.Concat(CONST.webHostPath, @"web.config"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region WebHost.csproj
				sb1.AppendFormat(CONST.WebHost_csproj, solutionName);
				loc1.Add(new BuildInfo(string.Concat(CONST.webHostPath, @"WebHost.csproj"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#endregion

				#region Module/Admin
				#region SysController.cs
				sb1.AppendFormat(CONST.Module_Admin_Controllers_SysController, solutionName, string.Join(string.Empty, admin_controllers_syscontroller_init_sysdir.ToArray()));
				loc1.Add(new BuildInfo(string.Concat(CONST.moduleAdminPath, @"Controllers\SysController.cs"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region LoginController.cs
				sb1.AppendFormat(CONST.Module_Admin_Controllers_LoginController, solutionName);
				loc1.Add(new BuildInfo(string.Concat(CONST.moduleAdminPath, @"Controllers\LoginController.cs"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region Views\Admin\Login\Index.cshtml
				sb1.AppendFormat(CONST.Module_Admin_Views_Login_Index_cshtml, solutionName);
				loc1.Add(new BuildInfo(string.Concat(CONST.moduleAdminPath, @"Views\Login\Index.cshtml"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region wwwroot\index.html
				sb1.AppendFormat(CONST.Module_Admin_wwwroot_index_html, solutionName, wwwroot_sitemap);
				loc1.Add(new BuildInfo(string.Concat(CONST.moduleAdminPath, @"wwwroot\index.html"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region appsettings.json
				loc1.Add(new BuildInfo(string.Concat(CONST.moduleAdminPath, @"appsettings.json"), Deflate.Compress("{\r\n}")));
				clearSb();
				#endregion

				#region Views\_ViewStart.cshtml
				sb1.AppendFormat(@"@{{
	Layout = ""_Layout"";
}}", solutionName);
				loc1.Add(new BuildInfo(string.Concat(CONST.moduleAdminPath, @"Views\_ViewStart.cshtml"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region Views\_ViewImports.cshtml
				sb1.AppendFormat(@"@using Newtonsoft.Json;
@using {0}.BLL;
@using {0}.Model;

@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
", solutionName);
				loc1.Add(new BuildInfo(string.Concat(CONST.moduleAdminPath, @"Views\_ViewImports.cshtml"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region Views\Shared\_Layout.cshtml
				sb1.AppendFormat(@"<!DOCTYPE html>
<html>
<head>
	<meta charset=""utf-8"">
	<title>@ViewBag.title</title>
	<link rel=""stylesheet"" href=""//cdn.bootcss.com/semantic-ui/2.1.8/semantic.min.css"">
	<link rel=""stylesheet"" href=""/css/style.css"">
	<script src=""//cdn.bootcss.com/jquery/1.11.3/jquery.min.js""></script>
	<script src=""//cdn.bootcss.com/semantic-ui/2.1.8/semantic.min.js""></script>
</head>
<body>

	@RenderBody()

</body>
</html>", solutionName);
				loc1.Add(new BuildInfo(string.Concat(CONST.moduleAdminPath, @"Views\Shared\_Layout.cshtml"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#region Admin.csproj
				sb1.AppendFormat(CONST.Module_csproj, "Admin");
				loc1.Add(new BuildInfo(string.Concat(CONST.moduleAdminPath, @"Admin.csproj"), Deflate.Compress(sb1.ToString())));
				clearSb();
				#endregion
				#endregion
			}
			if (isDownloadRes) {
				loc1.Add(new BuildInfo(string.Concat(CONST.corePath, @"..\htm.zip"), Server.Properties.Resources.htm_zip));
			}

			GC.Collect();
			return loc1;
		}
	}
}
