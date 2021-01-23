S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.2
Build-Number: R732XXU2EQC1
Build-Date: 2017.03.13 20:32:41

Crash Information
Process Name: scorekeeperforgear
PID: 6823
Date: 2017-06-18 20:36:45+0200
Executable File Path: /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000001
r2   = 0x00000000, r3   = 0x00000001
r4   = 0x00000000, r5   = 0xfffeec77
r6   = 0x418cb3a4, r7   = 0xbea8d480
r8   = 0x418b557d, r9   = 0xfffea3b5
r10  = 0xfffea3f1, fp   = 0xfffea415
ip   = 0x404d9b50, sp   = 0xbea8d1f8
lr   = 0x418b83d3, pc   = 0x404d9b58
cpsr = 0x60000010

Memory Information
MemTotal:   491132 KB
MemFree:     35932 KB
Buffers:      8216 KB
Cached:     118972 KB
VmPeak:      59428 KB
VmSize:      59424 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12008 KB
VmRSS:       12004 KB
VmData:       4260 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23100 KB
VmPTE:          38 KB
VmSwap:          0 KB

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40047000 r-xp /usr/lib/libappcore-efl.so.1.1
40056000 40063000 r-xp /usr/lib/libaul.so.0.1.0
4006d000 4006f000 r-xp /lib/libdl-2.13.so
40078000 4007b000 r-xp /usr/lib/libbundle.so.0.1.22
40083000 40085000 r-xp /usr/lib/libdlog.so.0.0.0
4008d000 400a1000 r-xp /lib/libpthread-2.13.so
400ac000 401e8000 r-xp /usr/lib/libelementary.so.1.7.99
401ff000 402cd000 r-xp /usr/lib/libevas.so.1.7.99
402f2000 40309000 r-xp /usr/lib/libecore.so.1.7.99
40320000 4037e000 r-xp /usr/lib/libedje.so.1.7.99
40388000 40458000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40459000 4045f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40467000 4046b000 r-xp /usr/lib/libsmack.so.1.0.0
40474000 4047c000 r-xp /lib/libgcc_s-4.6.so.1
4047d000 405a1000 r-xp /lib/libc-2.13.so
405af000 405cd000 r-xp /usr/lib/libsystemd.so.0.4.0
405d7000 405e2000 r-xp /lib/libunwind.so.8.0.1
4060f000 40626000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4062e000 40658000 r-xp /usr/lib/libdbus-1.so.3.8.12
40661000 40666000 r-xp /usr/lib/libxdgmime.so.1.1.0
4066e000 40691000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
40699000 4069a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
406a2000 406a8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406b1000 4071a000 r-xp /lib/libm-2.13.so
40723000 4073c000 r-xp /usr/lib/libeet.so.1.7.99
4074d000 4078e000 r-xp /usr/lib/libeina.so.1.7.99
40797000 407b9000 r-xp /usr/lib/libecore_evas.so.1.7.99
407c2000 407c7000 r-xp /usr/lib/libecore_file.so.1.7.99
407cf000 407e0000 r-xp /usr/lib/libecore_input.so.1.7.99
407e8000 407f1000 r-xp /usr/lib/libvconf.so.0.2.45
407f9000 40849000 r-xp /usr/lib/libecore_x.so.1.7.99
4084b000 40854000 r-xp /usr/lib/libedbus.so.1.7.99
4085c000 40876000 r-xp /usr/lib/libecore_con.so.1.7.99
4087f000 40892000 r-xp /usr/lib/libfribidi.so.0.3.1
4089a000 408df000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
408e8000 40910000 r-xp /usr/lib/libfontconfig.so.1.8.0
40911000 40967000 r-xp /usr/lib/libfreetype.so.6.11.3
40973000 409c9000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d6000 409dc000 r-xp /lib/librt-2.13.so
409e5000 409ec000 r-xp /usr/lib/libembryo.so.1.7.99
409f4000 40a0b000 r-xp /usr/lib/liblua-5.1.so
40a14000 40a1a000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a22000 40a23000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2b000 40a5a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a62000 40a65000 r-xp /lib/libcap.so.2.21
40a6d000 40a85000 r-xp /usr/lib/liblzma.so.5.0.3
40a8d000 40a9d000 r-xp /lib/libresolv-2.13.so
40aa1000 40b74000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40b7f000 40bb3000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40bbc000 40bd6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40bde000 40c53000 r-xp /usr/lib/libsqlite3.so.0.8.6
40c5d000 40c5f000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
40c67000 40c7d000 r-xp /lib/libz.so.1.2.5
40c85000 40ca8000 r-xp /usr/lib/libjpeg.so.8.0.2
40cc0000 40da1000 r-xp /usr/lib/libX11.so.6.3.0
40dac000 40db1000 r-xp /usr/lib/libecore_fb.so.1.7.99
40dba000 40dbe000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40dc7000 40dca000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40dd2000 40dd9000 r-xp /usr/lib/libXcursor.so.1.0.2
40de1000 40de3000 r-xp /usr/lib/libXdamage.so.1.1.0
40deb000 40ded000 r-xp /usr/lib/libXcomposite.so.1.0.0
40df5000 40df7000 r-xp /usr/lib/libXgesture.so.7.0.0
40dff000 40e02000 r-xp /usr/lib/libXfixes.so.3.1.0
40e0a000 40e13000 r-xp /usr/lib/libXi.so.6.1.0
40e1b000 40e1c000 r-xp /usr/lib/libXinerama.so.1.0.0
40e25000 40e2b000 r-xp /usr/lib/libXrandr.so.2.2.0
40e33000 40e39000 r-xp /usr/lib/libXrender.so.1.3.0
40e41000 40e45000 r-xp /usr/lib/libXtst.so.6.1.0
40e4d000 40e57000 r-xp /usr/lib/libXext.so.6.4.0
40e60000 40ea4000 r-xp /usr/lib/libcurl.so.4.3.0
40ead000 40ec3000 r-xp /lib/libexpat.so.1.6.0
40ecd000 40ee5000 r-xp /usr/lib/libpng12.so.0.50.0
40eed000 40f0a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f13000 40fa7000 r-xp /usr/lib/libstdc++.so.6.0.16
40fba000 40fbd000 r-xp /lib/libattr.so.1.1.0
40fc5000 40fc6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40fce000 40fd3000 r-xp /usr/lib/libffi.so.5.0.10
40fdc000 40fde000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
40fe6000 410b2000 r-xp /usr/lib/libxml2.so.2.7.8
410bf000 410c1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
410ca000 410cc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
410d4000 410e7000 r-xp /usr/lib/libxcb.so.1.1.0
410f1000 410fa000 r-xp /usr/lib/libcares.so.2.1.0
41103000 41131000 r-xp /usr/lib/libidn.so.11.5.44
41139000 41180000 r-xp /usr/lib/libssl.so.1.0.0
4118c000 4131e000 r-xp /usr/lib/libcrypto.so.1.0.0
41340000 41342000 r-xp /usr/lib/libiri.so
4134a000 41351000 r-xp /lib/libcrypt-2.13.so
41381000 41383000 r-xp /usr/lib/libXau.so.6.0.0
41490000 41494000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4149c000 414a4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
414a6000 414ab000 r-xp /usr/lib/libappcore-common.so.1.1
414b3000 414b5000 r-xp /usr/lib/libiniparser.so.0
414d4000 414d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
414e1000 414e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
414ec000 414f2000 r-xp /usr/lib/libappsvc.so.0.1.0
414fa000 4151e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41527000 415f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4160c000 41616000 r-xp /lib/libnss_files-2.13.so
418b2000 418bb000 r-xp /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
418cc000 418d1000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
418d9000 418e5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
418ee000 4190f000 r-xp /usr/lib/libefl-extension.so.0.1.0
41917000 4191c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41924000 4194e000 r-xp /usr/lib/libsensor.so.1.9.5
41957000 4195e000 r-xp /usr/lib/libctx-shared.so.0.8.3
41966000 4196b000 r-xp /usr/lib/libctx-client.so.0.8.3
41973000 41985000 r-xp /usr/lib/libefl-assist.so.0.1.0
4198d000 41a45000 r-xp /usr/lib/libcairo.so.2.11200.14
41a50000 41a5a000 r-xp /usr/lib/libsensord-shared.so
41a62000 41a71000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41a7a000 41a90000 r-xp /usr/lib/libtts.so
41a99000 41abc000 r-xp /usr/lib/libui-extension.so.0.1.0
41ac5000 41ad0000 r-xp /usr/lib/libtbm.so.1.0.0
41ad8000 41ae6000 r-xp /usr/lib/libGLESv2.so.2.0
41aef000 41af0000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41af9000 41aff000 r-xp /usr/lib/libxcb-render.so.0.0.0
41b07000 41b0a000 r-xp /usr/lib/libEGL.so.1.4
41b12000 41b15000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41b1d000 41b1e000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41b27000 41caf000 r-xp /usr/lib/libicui18n.so.57.1
41cbf000 41dc5000 r-xp /usr/lib/libicuuc.so.57.1
41ddb000 41de3000 r-xp /usr/lib/libdrm.so.2.4.0
41deb000 41ded000 r-xp /usr/lib/libdri2.so.0.0.0
41df5000 41dfb000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41e03000 41e08000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41e10000 41e29000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
436ca000 436eb000 r-xp /usr/lib/libexif.so.12.3.3
436fe000 43700000 r-xp /usr/lib/libttrace.so.1.1
43708000 4370d000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43715000 4371b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43724000 4372c000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43734000 43756000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4375f000 43766000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4376f000 43771000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43779000 43780000 r-xp /usr/lib/libminizip.so.1.0.0
43788000 43795000 r-xp /usr/lib/libail.so.0.1.0
4379e000 437a4000 r-xp /usr/lib/libproc-stat.so.0.2.96
437ac000 437ad000 r-xp /usr/lib/libresponse.so.0.2.96
437b5000 437ba000 r-xp /usr/lib/libsystem.so.0.0.0
437c4000 4388e000 r-xp /usr/lib/libCOREGL.so.4.0
bea6d000 bea8e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6823)
Call Stack Count: 6
 0: fclose + 0x8 (0x404d9b58) [/lib/libc.so.6] + 0x5cb58
 1: Configuration::createConfigurationTextFile() + 0x3e (0x418b83d3) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x63d3
 2: main + 0x32 (0x418b5493) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x3493
 3: (0x40001a53) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x1a53
 4: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
 5:  + 0x0 (0x40001e0c) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x1e0c
End of Call Stack

Package Information
Package Name: org.example.scorekeeperforgear
Package ID : org.example.scorekeeperforgear
Version: 1.0.0
Package Type: rpm
App Name: scorekeeperforgear
App ID: org.example.scorekeeperforgear
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
1/(2/No such file or directory).
06-18 20:36:41.262+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-18 20:36:41.262+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: preference_get_double(1214) > preference_get_double(1312) : inactive_10min_precaution_millisec error
06-18 20:36:41.262+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-18 20:36:41.262+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-18 20:36:41.262+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: preference_get_double(1214) > preference_get_double(1312) : inactive_before_10min_precaution_millisec error
06-18 20:36:41.997+0200 I/CAPI_WATCH_APPLICATION(  937): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-18 20:36:41.997+0200 E/watchface-app(  937): watchface.cpp: OnAppTimeTick(744) > 
06-18 20:36:41.997+0200 I/watchface-viewer(  937): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
06-18 20:36:41.997+0200 I/watchface-viewer(  937): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 275x63
06-18 20:36:42.002+0200 I/watchface-viewer(  937): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(577) > ImagesLoadingDoneSignal().Emit()
06-18 20:36:42.017+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:36:42.017+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:36:42.017+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:36:42.017+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-18 20:36:42.017+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-18 20:36:42.017+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:36:42.017+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-18 20:36:42.017+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:36:42.027+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:36:42.027+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:36:42.027+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:36:42.027+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-18 20:36:42.027+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-18 20:36:42.027+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:36:42.027+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-18 20:36:42.027+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-18 20:36:42.027+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-18 20:36:42.027+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:36:42.027+0200 E/CAPI_APPFW_APP_CONTROL( 1110): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-18 20:36:42.027+0200 W/MUSIC_CONTROL_SERVICE( 1110): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1110]   [com.samsung.w-home]register msg port [true][0m
06-18 20:36:42.027+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 14
06-18 20:36:42.037+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 802
06-18 20:36:42.042+0200 W/MUSIC_CONTROL_SERVICE( 1110): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1110]   [MUSIC_PLAYER_EVENT][0m
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-18 20:36:42.047+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:36:42.047+0200 W/MUSIC_CONTROL_SERVICE( 1110): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1110]   [MUSIC_PLAYER_EVENT][0m
06-18 20:36:42.052+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:36:42.052+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:36:42.052+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:36:42.052+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-18 20:36:42.052+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-18 20:36:42.052+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:36:42.052+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-18 20:36:42.052+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:36:42.052+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:36:42.052+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:36:42.052+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-18 20:36:42.057+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:36:42.072+0200 W/W_HOME  (  802): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
06-18 20:36:42.072+0200 E/W_HOME  (  802): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-18 20:36:42.077+0200 W/W_HOME  (  802): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
06-18 20:36:42.077+0200 E/W_HOME  (  802): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-18 20:36:42.167+0200 I/efl-extension( 3533): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-18 20:36:42.167+0200 I/efl-extension(  802): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-18 20:36:42.167+0200 I/efl-extension(  802): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x460706e8, elm_box, time_stamp : 1446409
06-18 20:36:42.167+0200 I/wnotib  (  802): w-notification-board-broker-main.c: _wnotib_rotary_cb(559) > Pass rotary event to home.
06-18 20:36:42.172+0200 W/W_HOME  (  802): home_navigation.c: _rotary_cb(1168) > Detent detected, obj[0x46056818], direction[0]
06-18 20:36:42.187+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:36:42.187+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
06-18 20:36:42.187+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-18 20:36:42.187+0200 W/W_HOME  (  802): home_navigation.c: _is_rightedge(187) > (1800 360) not right edge: 0 0 0x460e4078 -> 360 0 0x473682e8
06-18 20:36:42.192+0200 I/efl-extension(  802): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(633) > [0x46056818 : elm_scroller] rotary callabck is called.
06-18 20:36:42.197+0200 I/efl-extension(  802): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(663) > [0x46056818 : elm_scroller] block(2)
06-18 20:36:42.197+0200 I/efl-extension(  802): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(664) > [0x46056818 : elm_scroller] scroll_locked_x(0), scroll_locked_y(0)
06-18 20:36:42.197+0200 I/efl-extension(  802): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(665) > [0x46056818 : elm_scroller] content size (w, h)(6840, 360)
06-18 20:36:42.197+0200 I/efl-extension(  802): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(666) > [0x46056818 : elm_scroller] viewport size (w, h)(360, 360)
06-18 20:36:42.197+0200 I/efl-extension(  802): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(730) > [0x46056818 : elm_scroller] CurrentPage(5) DetentValue(1)
06-18 20:36:42.197+0200 I/efl-extension(  802): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(731) > [0x46056818 : elm_scroller] DetentCount(0)
06-18 20:36:42.197+0200 I/efl-extension(  802): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056818 : elm_scroller] mx(6480), my(0), minx(0), miny(0), px(1800), py(0)
06-18 20:36:42.197+0200 I/efl-extension(  802): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056818 : elm_scroller] mx(6480), my(0), minx(0), miny(0), px(1800), py(0)
06-18 20:36:42.197+0200 I/efl-extension(  802): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056818 : elm_scroller] mx(6480), my(0), minx(0), miny(0), px(1800), py(0)
06-18 20:36:42.197+0200 I/efl-extension(  802): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(763) > [0x46056818 : elm_scroller] bring in 6 page
06-18 20:36:42.197+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:5560 _elm_scroll_page_bring_in() [0x46056818 : elm_scroller] pagenumber_h(6), pagenumber_v(0)
06-18 20:36:42.202+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x46056818 : elm_scroller] mx(6480), my(0), minx(0), miny(0), px(1800), py(0)
06-18 20:36:42.202+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x46056818 : elm_scroller] cw(6840), ch(360), pw(360), ph(360)
06-18 20:36:42.202+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x46056818 : elm_scroller] x(2160), y(0), nx(2160), px(1800), ny(0) py(0)
06-18 20:36:42.202+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x46056818 : elm_scroller] x(2160), y(0)
06-18 20:36:42.202+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:5578 _elm_scroll_page_bring_in() [0x46056818 : elm_scroller] _elm_scroll_content_region_show_internal() return TRUE!! x(2160), y(0)
06-18 20:36:42.202+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x46056818 : elm_scroller] t_in(0,270000), pos_x(2160)
06-18 20:36:42.202+0200 W/W_HOME  (  802): home_navigation.c: _anim_start_cb(1290) > anim start
06-18 20:36:42.202+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:36:42.202+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x46056818 : elm_scroller] t_in(0,270000), pos_y(0)
06-18 20:36:42.202+0200 W/W_HOME  (  802): event_manager.c: _home_scroll_cb(585) > scroll,will,start
06-18 20:36:42.202+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 2, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:36:42.207+0200 W/W_HOME  (  802): event_manager.c: _home_scroll_cb(585) > scroll,start
06-18 20:36:42.207+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:36:42.227+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,401028)
06-18 20:36:42.227+0200 W/W_HOME  (  802): event_manager.c: _clock_view_obscured_cb(651) > state: 1 -> 0
06-18 20:36:42.227+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:36:42.227+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:36:42.232+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-18 20:36:42.232+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-18 20:36:42.232+0200 W/W_INDICATOR(  796): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
06-18 20:36:42.232+0200 W/W_INDICATOR(  796): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-18 20:36:42.232+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1944), py(0)
06-18 20:36:42.232+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,401028)
06-18 20:36:42.232+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1944), py(0)
06-18 20:36:42.247+0200 W/W_HOME  (  802): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
06-18 20:36:42.247+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,494924)
06-18 20:36:42.247+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-18 20:36:42.247+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-18 20:36:42.247+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1978), py(0)
06-18 20:36:42.247+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,494924)
06-18 20:36:42.247+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1978), py(0)
06-18 20:36:42.262+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,584261)
06-18 20:36:42.262+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-18 20:36:42.262+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-18 20:36:42.267+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2010), py(0)
06-18 20:36:42.267+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,584261)
06-18 20:36:42.267+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2010), py(0)
06-18 20:36:42.277+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,647038)
06-18 20:36:42.277+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-18 20:36:42.277+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-18 20:36:42.277+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2032), py(0)
06-18 20:36:42.282+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,647038)
06-18 20:36:42.282+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2032), py(0)
06-18 20:36:42.297+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,733763)
06-18 20:36:42.297+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-18 20:36:42.297+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-18 20:36:42.302+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2064), py(0)
06-18 20:36:42.302+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,733763)
06-18 20:36:42.302+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2064), py(0)
06-18 20:36:42.312+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,783197)
06-18 20:36:42.312+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-18 20:36:42.312+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-18 20:36:42.312+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2081), py(0)
06-18 20:36:42.312+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,783197)
06-18 20:36:42.312+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2081), py(0)
06-18 20:36:42.327+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,829342)
06-18 20:36:42.327+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-18 20:36:42.327+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-18 20:36:42.327+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2098), py(0)
06-18 20:36:42.327+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,829342)
06-18 20:36:42.327+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2098), py(0)
06-18 20:36:42.342+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,876484)
06-18 20:36:42.342+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-18 20:36:42.342+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-18 20:36:42.342+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2115), py(0)
06-18 20:36:42.342+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,876484)
06-18 20:36:42.342+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2115), py(0)
06-18 20:36:42.357+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,908508)
06-18 20:36:42.357+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-18 20:36:42.357+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-18 20:36:42.357+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2127), py(0)
06-18 20:36:42.357+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,908508)
06-18 20:36:42.357+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2127), py(0)
06-18 20:36:42.367+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,937768)
06-18 20:36:42.372+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-18 20:36:42.372+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-18 20:36:42.372+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2137), py(0)
06-18 20:36:42.372+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,937768)
06-18 20:36:42.372+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2137), py(0)
06-18 20:36:42.387+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,963672)
06-18 20:36:42.387+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-18 20:36:42.387+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-18 20:36:42.392+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2146), py(0)
06-18 20:36:42.392+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,963672)
06-18 20:36:42.392+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2146), py(0)
06-18 20:36:42.402+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,985686)
06-18 20:36:42.407+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-18 20:36:42.407+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-18 20:36:42.407+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2154), py(0)
06-18 20:36:42.407+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,985686)
06-18 20:36:42.407+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2154), py(0)
06-18 20:36:42.422+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,996517)
06-18 20:36:42.422+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-18 20:36:42.422+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-18 20:36:42.427+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2158), py(0)
06-18 20:36:42.427+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,996517)
06-18 20:36:42.427+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(2158), py(0)
06-18 20:36:42.442+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,999735)
06-18 20:36:42.442+0200 I/CAPI_WIDGET_APPLICATION(  962): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
06-18 20:36:42.442+0200 W/AUL     (  962): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.app-widget.widget) pid(962) status(fg) type(widgetapp)
06-18 20:36:42.442+0200 I/CAPI_WIDGET_APPLICATION(  962): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
06-18 20:36:42.442+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-18 20:36:42.442+0200 I/ELM_RPANEL(  802): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-18 20:36:42.447+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_CANCEL : px(2160), py(0)
06-18 20:36:42.447+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,999735)
06-18 20:36:42.452+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] animation stop!!
06-18 20:36:42.467+0200 W/wnotib  (  802): w-notification-board-panel-manager.c: _wnb_pm_anim_stop_cb(96) > notiboard scroller anim stop [2160][0][360][360]
06-18 20:36:42.467+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(969) > No postponed update with is_for_VI: 1.
06-18 20:36:42.467+0200 W/W_HOME  (  802): home_navigation.c: _anim_stop_cb(1316) > anim stop
06-18 20:36:42.467+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:36:42.472+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
06-18 20:36:42.472+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-18 20:36:42.472+0200 I/efl-extension(  802): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(489) > [0x46056818 : elm_scroller] detent_count(1)
06-18 20:36:42.472+0200 I/efl-extension(  802): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(490) > [0x46056818 : elm_scroller] pagenumber_v(0), pagenumber_h(6)
06-18 20:36:42.472+0200 I/efl-extension(  802): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(512) > [0x46056818 : elm_scroller] CurrentPage(6)
06-18 20:36:42.472+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_CANCEL : px(2160), py(0)
06-18 20:36:42.482+0200 W/WATCH_CORE(  937): appcore-watch.c: __widget_pause(1113) > widget_pause
06-18 20:36:42.482+0200 W/AUL     (  937): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.watchface.TacticalSentry) pid(937) status(bg) type(watchapp)
06-18 20:36:42.482+0200 E/watchface-app(  937): watchface.cpp: OnAppPause(717) > 
06-18 20:36:42.582+0200 E/W_HOME  (  802): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
06-18 20:36:42.602+0200 W/W_HOME  (  802): event_manager.c: _home_scroll_cb(585) > scroll,will,done
06-18 20:36:42.602+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:36:42.602+0200 W/W_HOME  (  802): event_manager.c: _home_scroll_cb(585) > scroll,done
06-18 20:36:42.602+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:36:42.947+0200 E/EFL     (  802): ecore_x<802> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1447189 button=1
06-18 20:36:42.947+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:36:42.952+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:36:42.952+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:36:42.952+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:36:42.967+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:36:42.967+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:36:42.977+0200 E/EFL     (  802): ecore_x<802> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1447218 button=1
06-18 20:36:42.977+0200 W/W_HOME  (  802): home_navigation.c: _up_cb(1247) > up
06-18 20:36:42.977+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:36:42.977+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-18 20:36:42.982+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:36:42.982+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:36:42.982+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:36:42.997+0200 W/AUL     (  962): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.scorekeeperforgear)
06-18 20:36:43.002+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 0
06-18 20:36:43.002+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1782) > caller pid : 962
06-18 20:36:43.002+0200 I/AUL_AMD (  504): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
06-18 20:36:43.027+0200 E/RESOURCED(  648): block.c: block_prelaunch_state(138) > insert data org.example.scorekeeperforgear, table num : 4
06-18 20:36:43.032+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2218) > pad pid(-5)
06-18 20:36:43.032+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
06-18 20:36:43.032+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
06-18 20:36:43.032+0200 W/AUL_PAD ( 6763): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
06-18 20:36:43.032+0200 W/AUL_PAD ( 6763): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
06-18 20:36:43.032+0200 W/AUL_PAD ( 6763): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
06-18 20:36:43.037+0200 W/AUL_PAD ( 6763): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.scorekeeperforgear)
06-18 20:36:43.082+0200 I/efl-extension( 6763): efl_extension.c: eext_mod_init(40) > Init
06-18 20:36:43.087+0200 I/UXT     ( 6763): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
06-18 20:36:43.102+0200 W/AUL_PAD ( 6763): launchpad_loader.c: main(690) > [candidate] dlsym
06-18 20:36:43.102+0200 W/AUL_PAD ( 6763): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.scorekeeperforgear)
06-18 20:36:43.217+0200 W/CRASH_MANAGER( 6749): worker.c: worker_job(1205) > 110676373636f1497811003
06-18 20:36:43.232+0200 E/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(287) > error founded when being launched with 6763
06-18 20:36:43.232+0200 E/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(289) > The app process might be terminated while we are wating 6763
06-18 20:36:43.232+0200 W/AUL     (  504): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.scorekeeperforgear) pid(6763) type(uiapp) bg(2)
06-18 20:36:43.237+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-18 20:36:43.237+0200 W/AUL     (  962): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6763)
06-18 20:36:43.237+0200 W/STARTER (  769): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6763]
06-18 20:36:43.477+0200 W/W_HOME  (  802): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
06-18 20:36:43.977+0200 E/EFL     (  386): ecore_x<386> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x2800003 time=1447218
06-18 20:36:43.977+0200 E/EFL     (  802): ecore_x<802> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=1447218
06-18 20:36:43.977+0200 E/EFL     (  386): ecore_x<386> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=1447218
06-18 20:36:44.237+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-18 20:36:44.237+0200 W/AUL_AMD (  504): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
06-18 20:36:44.292+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6763 pgid = 6763
06-18 20:36:44.292+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
06-18 20:36:44.302+0200 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __read_proc(55) > file open error : 2
06-18 20:36:44.302+0200 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
06-18 20:36:44.302+0200 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(6763), proc(0)
06-18 20:36:44.302+0200 E/AUL     ( 1009): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
06-18 20:36:44.302+0200 E/CAPI_APPFW_APP_MANAGER( 1009): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
06-18 20:36:44.302+0200 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
06-18 20:36:44.377+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
06-18 20:36:44.377+0200 I/AUL_AMD (  504): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6763
06-18 20:36:44.377+0200 W/AUL     (  504): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6763)
06-18 20:36:44.492+0200 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __read_proc(55) > file open error : 2
06-18 20:36:44.492+0200 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
06-18 20:36:44.492+0200 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(6763), proc(0)
06-18 20:36:44.492+0200 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
06-18 20:36:44.492+0200 E/AUL     ( 1312): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
06-18 20:36:44.492+0200 E/CAPI_APPFW_APP_MANAGER( 1312): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
06-18 20:36:44.497+0200 I/AUL_PAD ( 6823): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
06-18 20:36:45.032+0200 E/EFL     (  802): ecore_x<802> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1449273 button=1
06-18 20:36:45.032+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:36:45.032+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:36:45.057+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:36:45.057+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:36:45.057+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:36:45.062+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:36:45.062+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:36:45.082+0200 E/EFL     (  802): ecore_x<802> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1449316 button=1
06-18 20:36:45.087+0200 W/W_HOME  (  802): home_navigation.c: _up_cb(1247) > up
06-18 20:36:45.087+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:36:45.087+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-18 20:36:45.102+0200 W/AUL     (  962): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.scorekeeperforgear)
06-18 20:36:45.102+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 0
06-18 20:36:45.107+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1782) > caller pid : 962
06-18 20:36:45.107+0200 I/AUL_AMD (  504): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
06-18 20:36:45.122+0200 E/RESOURCED(  648): block.c: block_prelaunch_state(138) > insert data org.example.scorekeeperforgear, table num : 4
06-18 20:36:45.122+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2218) > pad pid(-5)
06-18 20:36:45.127+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
06-18 20:36:45.127+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
06-18 20:36:45.127+0200 W/AUL_PAD ( 6823): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
06-18 20:36:45.127+0200 W/AUL_PAD ( 6823): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
06-18 20:36:45.127+0200 W/AUL_PAD ( 6823): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
06-18 20:36:45.127+0200 W/AUL_PAD ( 6823): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.scorekeeperforgear)
06-18 20:36:45.177+0200 I/efl-extension( 6823): efl_extension.c: eext_mod_init(40) > Init
06-18 20:36:45.182+0200 I/UXT     ( 6823): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
06-18 20:36:45.197+0200 W/AUL_PAD ( 6823): launchpad_loader.c: main(690) > [candidate] dlsym
06-18 20:36:45.197+0200 W/AUL_PAD ( 6823): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.scorekeeperforgear)
06-18 20:36:45.292+0200 E/EFL     (  802): ecore_x<802> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1449538 button=1
06-18 20:36:45.297+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:36:45.297+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:36:45.302+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:36:45.302+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:36:45.327+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:36:45.327+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:36:45.347+0200 W/CRASH_MANAGER( 6749): worker.c: worker_job(1205) > 110682373636f149781100
