S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.2
Build-Number: R732XXU2EQC1
Build-Date: 2017.03.13 20:32:41

Crash Information
Process Name: scorekeeperforgear
PID: 6866
Date: 2017-06-18 20:36:55+0200
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
r6   = 0x418cb3a4, r7   = 0xbecb3480
r8   = 0x418b557d, r9   = 0xfffea3b5
r10  = 0xfffea3f1, fp   = 0xfffea415
ip   = 0x404d9b50, sp   = 0xbecb31f8
lr   = 0x418b83d3, pc   = 0x404d9b58
cpsr = 0x60000010

Memory Information
MemTotal:   491132 KB
MemFree:     25956 KB
Buffers:      8408 KB
Cached:     123208 KB
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
bec93000 becb4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6866)
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
W/W_HOME  (  802): main.c: _appcore_pause_cb(487) > appcore pause
06-18 20:36:58.027+0200 W/W_HOME  (  802): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
06-18 20:36:58.027+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:36:58.027+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:36:58.027+0200 W/W_HOME  (  802): main.c: home_pause(546) > clock/widget paused
06-18 20:36:58.027+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-18 20:36:58.032+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:36:58.032+0200 E/CAPI_APPFW_APP_CONTROL( 1110): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-18 20:36:58.032+0200 W/MUSIC_CONTROL_SERVICE( 1110): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1110]   [com.samsung.w-home]register msg port [false][0m
06-18 20:36:58.052+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [769].
06-18 20:36:58.057+0200 E/APP_SHORTCUT_WIDGET(  962): main.c: widget_instance_pause(1669) >  (!popup) -> widget_instance_pause() return
06-18 20:36:58.057+0200 I/CAPI_WIDGET_APPLICATION(  962): widget_app.c: __provider_pause_cb(298) > widget obj was paused
06-18 20:36:58.057+0200 W/AUL     (  962): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.app-widget.widget) pid(962) status(bg) type(widgetapp)
06-18 20:36:58.057+0200 I/CAPI_WIDGET_APPLICATION(  962): widget_app.c: __check_status_for_cgroup(145) > enter background group
06-18 20:36:58.072+0200 W/W_INDICATOR(  796): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
06-18 20:36:58.082+0200 E/ALARM_MANAGER(  509): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 187354999, next duetime: 1497811038
06-18 20:36:58.082+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(187354999)
06-18 20:36:58.082+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1497818871), due_time(1497811038)
06-18 20:36:58.092+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
06-18 20:36:58.102+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-18 20:36:58.102+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 18-6-2017, 18:37:18 (UTC).
06-18 20:36:58.102+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-18 20:36:58.102+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __save_module_log(1778) > The file is not ready.
06-18 20:36:58.107+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
06-18 20:36:58.112+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __save_module_log(1778) > The file is not ready.
06-18 20:36:58.122+0200 I/w-magazine-widget(  979): widget.c: _magazine_widget_display_status_cb(493) > LCD off
06-18 20:36:58.127+0200 I/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
06-18 20:36:58.142+0200 W/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
06-18 20:36:58.142+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
06-18 20:36:58.142+0200 I/HIGEAR  ( 1378): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
06-18 20:36:58.162+0200 W/SHealthCommon( 1312): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:3[0;m
06-18 20:36:58.187+0200 W/SHealthService( 1312): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
06-18 20:36:58.192+0200 W/W_INDICATOR(  796): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
06-18 20:36:58.192+0200 W/W_INDICATOR(  796): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-18 20:36:58.312+0200 W/W_INDICATOR(  796): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
06-18 20:36:58.312+0200 W/W_INDICATOR(  796): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
06-18 20:36:58.312+0200 W/W_INDICATOR(  796): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
06-18 20:36:58.532+0200 I/APP_CORE(  802): appcore-efl.c: __do_app(453) > [APP 802] Event: MEM_FLUSH State: PAUSED
06-18 20:36:58.607+0200 E/wnoti-service( 1154): wnoti-consumer.c: on_receive(462) > on receive called. noti(1), handle(1) payloadLength(47)
06-18 20:36:58.612+0200 E/wnoti-service( 1154): wnoti-sap-client.c: publish_received_noti(1924) > type : 2, category : 0, source : 7, feedback : -1, popup_type(RICH) : 0, application_id : 52418, seq_num : 229421, noti_flag : 0, g_span_version : 1, update_summary_icons : 0, latest_child_time : 0.000000, latest_summary_time : 0.000000, android_time : 0.000000
06-18 20:36:58.622+0200 E/wnoti-service( 1154): wnoti-db-utility.c: lock_pm(599) > >> lock_pm status : 2
06-18 20:36:58.662+0200 E/wnoti-service( 1154): wnoti-db-utility.c: set_pm_lock(583) > >> set_pm_lock status : 1
06-18 20:36:58.662+0200 E/wnoti-service( 1154): wnoti-db-utility.c: unlock_pm(614) > >> unlock_pm status : 1
06-18 20:36:58.667+0200 E/wnoti-service( 1154): wnoti-consumer.c: on_receive(462) > on receive called. noti(1), handle(1) payloadLength(44)
06-18 20:36:58.667+0200 E/wnoti-service( 1154): wnoti-sap-client.c: publish_received_noti(1924) > type : 2, category : 0, source : 7, feedback : -1, popup_type(RICH) : 0, application_id : -1, seq_num : 229420, noti_flag : 0, g_span_version : 1, update_summary_icons : 0, latest_child_time : 0.000000, latest_summary_time : 0.000000, android_time : 0.000000
06-18 20:36:58.667+0200 E/wnoti-service( 1154): wnoti-db-utility.c: lock_pm(599) > >> lock_pm status : 1
06-18 20:36:58.667+0200 E/wnoti-service( 1154): wnoti-db-server.c: clear_notification_card(3105) > _query_step failed()
06-18 20:36:58.672+0200 E/wnoti-service( 1154): wnoti-db-server.c: clear_notification_card_by_window_id(3019) > _query_step failed()
06-18 20:36:58.672+0200 E/wnoti-service( 1154): wnoti-db-utility.c: unlock_pm(614) > >> unlock_pm status : 1
06-18 20:36:58.677+0200 E/wnoti-service( 1154): wnoti-consumer.c: on_receive(462) > on receive called. noti(1), handle(1) payloadLength(1928)
06-18 20:36:58.677+0200 E/wnoti-service( 1154): wnoti-sap-client.c: _parse_received_noti(2660) > application_id : 52418
06-18 20:36:58.677+0200 E/wnoti-service( 1154): wnoti-db-utility.c: lock_pm(599) > >> lock_pm status : 1
06-18 20:36:58.677+0200 E/wnoti-service( 1154): wnoti-db-server.c: insert_panel_asset(3618) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/3216
06-18 20:36:58.677+0200 E/wnoti-service( 1154): wnoti-db-server.c: insert_panel_asset(3618) > [panel noti, cache image]attr_type : 19, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/3217
06-18 20:36:58.682+0200 E/wnoti-service( 1154): wnoti-json-parser.c: wnoti_parse_android_wear_action(314) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/3184
06-18 20:36:58.682+0200 E/wnoti-service( 1154): wnoti-json-parser.c: wnoti_parse_android_wear_action(356) > noti_info->action_type : 0
06-18 20:36:58.682+0200 E/wnoti-service( 1154): wnoti-sap-client.c: _parse_normal_attribute(1171) > ATTR_ANDROID_WEARABLE, len : 143
06-18 20:36:58.687+0200 E/wnoti-service( 1154): wnoti-db-server.c: check_asset_images(3891) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/3216
06-18 20:36:58.687+0200 E/wnoti-service( 1154): wnoti-db-server.c: check_asset_images(3891) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/3217
06-18 20:36:58.687+0200 E/wnoti-service( 1154): wnoti-db-server.c: check_asset_images(3891) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/3184
06-18 20:36:58.697+0200 E/wnoti-service( 1154): wnoti-utility.c: is_check_image_size(1447) > src_w [48] src_h [48]
06-18 20:36:58.697+0200 E/wnoti-service( 1154): wnoti-db-server.c: check_asset_images(3928) > summary_bg_image : /opt/usr/data/wnoti/.2819.png
06-18 20:36:58.707+0200 E/wnoti-service( 1154): wnoti-db-server.c: wnoti_is_check_notification_update(4238) > 0/0
06-18 20:36:58.707+0200 E/wnoti-service( 1154): wnoti-sap-client.c: _add_exception_handling(622) > type : 0, application_id : 52418
06-18 20:36:58.712+0200 E/wnoti-service( 1154): wnoti-sap-client.c: publish_received_noti(1924) > type : 0, category : 1002, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 52418, seq_num : 229422, noti_flag : 1049105, g_span_version : 1, update_summary_icons : 0, latest_child_time : 0.000000, latest_summary_time : 0.000000, android_time : 1497811017394.000000
06-18 20:36:58.712+0200 E/wnoti-service( 1154): wnoti-sap-client.c: publish_received_noti(1964) > latest_noti_card_time : 0.000000, latest_summary_noti_time : 0.000000
06-18 20:36:58.722+0200 E/wnoti-service( 1154): wnoti-db-utility.c: lock_pm(599) > >> lock_pm status : 1
06-18 20:36:58.742+0200 E/wnoti-service( 1154): wnoti-db-server.c: _wnoti_update_category(861) > Reuse category, application_id : 52418
06-18 20:36:58.757+0200 E/wnoti-service( 1154): wnoti-sap-client.c: publish_received_noti(2121) > group summary & grouping_id
06-18 20:36:58.757+0200 E/wnoti-service( 1154): wnoti-db-utility.c: set_pm_lock(583) > >> set_pm_lock status : 1
06-18 20:36:58.762+0200 E/wnoti-service( 1154): wnoti-db-server.c: set_global_noti_count(1609) > pre_count : 1, count : 5
06-18 20:36:58.762+0200 E/wnoti-service( 1154): wnoti-db-utility.c: unlock_pm(614) > >> unlock_pm status : 1
06-18 20:36:58.762+0200 E/wnoti-service( 1154): wnoti-consumer.c: on_receive(462) > on receive called. noti(1), handle(1) payloadLength(1397)
06-18 20:36:58.762+0200 E/wnoti-service( 1154): wnoti-sap-client.c: _parse_received_noti(2660) > application_id : 52418
06-18 20:36:58.762+0200 E/wnoti-service( 1154): wnoti-db-utility.c: lock_pm(599) > >> lock_pm status : 1
06-18 20:36:58.762+0200 E/wnoti-service( 1154): wnoti-db-server.c: insert_panel_asset(3618) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/3216
06-18 20:36:58.767+0200 E/wnoti-service( 1154): wnoti-db-server.c: insert_panel_asset(3618) > [panel noti, cache image]attr_type : 19, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/3217
06-18 20:36:58.767+0200 E/wnoti-service( 1154): wnoti-json-parser.c: wnoti_parse_panel_action(472) > ICON_URI : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/3231
06-18 20:36:58.772+0200 E/wnoti-service( 1154): wnoti-sap-client.c: _parse_normal_attribute(1202) > ATTR_ACTIONS, len : 174
06-18 20:36:58.772+0200 E/wnoti-service( 1154): wnoti-json-parser.c: wnoti_parse_android_wear_action(314) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/3184
06-18 20:36:58.772+0200 E/wnoti-service( 1154): wnoti-json-parser.c: wnoti_parse_android_wear_action(356) > noti_info->action_type : 2
06-18 20:36:58.772+0200 E/wnoti-service( 1154): wnoti-sap-client.c: _parse_normal_attribute(1171) > ATTR_ANDROID_WEARABLE, len : 304
06-18 20:36:58.777+0200 E/wnoti-service( 1154): wnoti-db-server.c: check_asset_images(3891) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/3216
06-18 20:36:58.777+0200 E/wnoti-service( 1154): wnoti-db-server.c: check_asset_images(3891) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/3217
06-18 20:36:58.777+0200 E/wnoti-service( 1154): wnoti-db-server.c: check_asset_images(3891) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/3231
06-18 20:36:58.777+0200 E/wnoti-service( 1154): wnoti-db-server.c: check_asset_images(3891) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/3184
06-18 20:36:58.782+0200 E/wnoti-service( 1154): wnoti-utility.c: is_check_image_size(1447) > src_w [48] src_h [48]
06-18 20:36:58.782+0200 E/wnoti-service( 1154): wnoti-db-server.c: check_asset_images(3928) > summary_bg_image : /opt/usr/data/wnoti/.2819.png
06-18 20:36:58.782+0200 E/wnoti-service( 1154): wnoti-db-server.c: check_asset_images(3891) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/3183
06-18 20:36:58.802+0200 E/wnoti-service( 1154): wnoti-db-server.c: _clear_summary_noti(1002) > summary popup : 16868, seq_num : 229422
06-18 20:36:58.822+0200 E/wnoti-service( 1154): wnoti-db-server.c: wnoti_is_check_notification_update(4238) > 0/0
06-18 20:36:58.822+0200 E/wnoti-service( 1154): wnoti-sap-client.c: _add_exception_handling(622) > type : 0, application_id : 52418
06-18 20:36:58.822+0200 E/wnoti-service( 1154): wnoti-sap-client.c: publish_received_noti(1924) > type : 0, category : 1000, source : 0, feedback : 2, popup_type(RICH) : 0, application_id : 52418, seq_num : 229423, noti_flag : 1048593, g_span_version : 1, update_summary_icons : 0, latest_child_time : 0.000000, latest_summary_time : 0.000000, android_time : 1497811017326.000000
06-18 20:36:58.827+0200 E/wnoti-service( 1154): wnoti-sap-client.c: publish_received_noti(1964) > latest_noti_card_time : 0.000000, latest_summary_noti_time : 1497811017394.000000
06-18 20:36:58.827+0200 E/wnoti-service( 1154): wnoti-db-utility.c: lock_pm(599) > >> lock_pm status : 1
06-18 20:36:58.862+0200 I/wnoti-service( 1154): wnoti-sap-client.c: launch_alert_view(431) > timer_id : 0, emergency_cb_mode : 0, blocking_mode : 0  
06-18 20:36:58.862+0200 E/wnoti-service( 1154): wnoti-db-utility.c: set_pm_lock(583) > >> set_pm_lock status : 1
06-18 20:36:58.862+0200 E/wnoti-service( 1154): wnoti-db-server.c: set_global_noti_count(1609) > pre_count : 1, count : 5
06-18 20:36:58.862+0200 E/wnoti-service( 1154): wnoti-db-utility.c: unlock_pm(614) > >> unlock_pm status : 1
06-18 20:36:58.862+0200 W/AUL     ( 1154): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.wnotiboard-popup)
06-18 20:36:58.862+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 0
06-18 20:36:58.877+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
06-18 20:36:58.887+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
06-18 20:36:58.887+0200 E/AUL_AMD (  504): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
06-18 20:36:58.892+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1782) > caller pid : 1154
06-18 20:36:58.902+0200 W/AUL     (  504): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.wnotiboard-popup) pid(3533) type(uiapp) bg(0)
06-18 20:36:58.902+0200 W/AUL_AMD (  504): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 3533
06-18 20:36:58.902+0200 W/AUL_AMD (  504): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(3533), cmd(0)
06-18 20:36:58.902+0200 I/APP_CORE( 3533): appcore-efl.c: __do_app(453) > [APP 3533] Event: RESET State: RUNNING
06-18 20:36:58.902+0200 I/CAPI_APPFW_APPLICATION( 3533): app_main.c: app_appcore_reset(245) > app_appcore_reset
06-18 20:36:58.902+0200 I/wnotibp ( 3533): wnotiboard-popup.c: _popup_app_control(169) > popup launch-type: alert
06-18 20:36:58.902+0200 I/APP_CORE( 3533): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
06-18 20:36:58.907+0200 W/STARTER (  769): pkg-monitor.c: _app_mgr_status_cb(416) > [_app_mgr_status_cb:416] Resume request [3533]
06-18 20:36:58.907+0200 W/AUL     ( 1154): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3533)
06-18 20:36:58.907+0200 E/wnoti-service( 1154): wnoti-sap-client.c: on_timer(280) > >> launching notification popup
06-18 20:36:58.907+0200 E/wnoti-service( 1154): wnoti-sap-client.c: on_timer(313) > is_exist_alert_list : 0, g_launch_popup_time : 1497811018, g_use_aul_launch : 1497811018
06-18 20:36:58.982+0200 I/APP_CORE( 6837): appcore-efl.c: __do_app(453) > [APP 6837] Event: MEM_FLUSH State: PAUSED
06-18 20:36:59.167+0200 E/wnoti-service( 1154): wnoti-db-utility.c: set_pm_lock(583) > >> set_pm_lock status : 2
06-18 20:36:59.172+0200 E/wnoti-service( 1154): wnoti-db-utility.c: unlock_pm(614) > >> unlock_pm status : 0
06-18 20:36:59.177+0200 E/wnoti-service( 1154): wnoti-db-server.c: set_global_noti_count(1609) > pre_count : 1, count : 5
06-18 20:36:59.362+0200 E/wnoti-service( 1154): wnoti-msg-builder.c: _publish_notification(1565) > operation_type : 0, source : 0, application_id : 0, display_count : 0, 
06-18 20:36:59.367+0200 E/wnoti-proxy( 3533): wnoti-client.c: on_wnoti_event(1026) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 3533, caller_id : 0, listener_type : 0
06-18 20:36:59.372+0200 E/wnoti-proxy(  802): wnoti-client.c: on_wnoti_event(1026) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 802, caller_id : 0, listener_type : 0
06-18 20:36:59.462+0200 E/wnoti-service( 1154): wnoti-sap-client.c: _get_latest_notification_card(1741) > id : 16869, status : 0
06-18 20:36:59.482+0200 E/wnoti-service( 1154): wnoti-db-server.c: wnoti_insert_alert_noti(1902) > data id is duplicated, id : 16869
06-18 20:36:59.482+0200 I/wnoti-service( 1154): wnoti-sap-client.c: launch_alert_view(431) > timer_id : 0, emergency_cb_mode : 0, blocking_mode : 0  
06-18 20:36:59.482+0200 E/wnoti-service( 1154): wnoti-db-utility.c: set_pm_lock(583) > >> set_pm_lock status : 1
06-18 20:36:59.482+0200 E/wnoti-service( 1154): wnoti-msg-builder.c: _publish_notification(1565) > operation_type : 0, source : 0, application_id : 0, display_count : 0, 
06-18 20:36:59.487+0200 E/wnoti-service( 1154): wnoti-sap-client.c: on_timer(313) > is_exist_alert_list : 0, g_launch_popup_time : 1497811019, g_use_aul_launch : 1497811018
06-18 20:36:59.492+0200 E/wnoti-proxy( 3533): wnoti-client.c: on_wnoti_event(1026) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 3533, caller_id : 0, listener_type : 0
06-18 20:36:59.492+0200 E/wnoti-proxy(  802): wnoti-client.c: on_wnoti_event(1026) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 802, caller_id : 0, listener_type : 0
06-18 20:36:59.517+0200 I/wnotibp ( 3533): wnotiboard-popup-control.c: _ctrl_service_changed_cb(241) > Handle this change type in idler.
06-18 20:36:59.522+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_data_changed_cb(787) > Change type : 0, op_type: 0, category_id: 0, display count: 0
06-18 20:36:59.522+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_data_changed_cb(821) > Handle this change type in idler.
06-18 20:36:59.522+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_data_changed_cb(834) > Proceed idler job.
06-18 20:36:59.522+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(434) > idler for type: 0
06-18 20:36:59.527+0200 E/wnoti-service( 1154): wnoti-db-client.c: wnoti_get_alert_categories(1142) > !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! application_id : 52418, db_id : 16869, is_duplicated : 0
06-18 20:36:59.532+0200 E/wnoti-service( 1154): wnoti-db-client.c: wnoti_get_alert_categories(1290) > view_type : 0, turn_screen_on : 0, allow_gesture : 1, is_used_popup : 0, feedback : 0
06-18 20:36:59.557+0200 I/wnoti-proxy( 3533): wnoti-client.c: is_mini_app(1795) > is_mini_app : 0
06-18 20:36:59.557+0200 I/wnotibp ( 3533): wnotiboard-popup-data.c: _data_get_alert_list(219) > application_name: franceinfo, application_id: 52418, category_id: 9036, time: 1497811017, launch_app_id: (null), bg_image: /opt/usr/data/wnoti/.app_icon_52418.png, icon_color: -8888280, disble_block_app_action: 0, support_large_icon 0
06-18 20:36:59.557+0200 I/wnotibp ( 3533): wnotiboard-popup-data.c: _data_get_alert_list(229) > noti_type: 1
06-18 20:36:59.557+0200 I/wnotibp ( 3533): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(60) > db_id: 16869, noti_type: 1
06-18 20:36:59.557+0200 I/wnotibp ( 3533): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(86) > is_source_companion: 1, content_id: 0, notification_id: 1037
06-18 20:36:59.557+0200 I/wnotibp ( 3533): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(470) > Activity fetch finished: -1
06-18 20:36:59.557+0200 I/wnotibp ( 3533): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(475) > activity action count: 1
06-18 20:36:59.557+0200 I/wnotibp ( 3533): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(480) > 1 activities retrieved.
06-18 20:36:59.557+0200 W/wnotibp ( 3533): wnotiboard-popup-data.c: _data_convert_alert_data(65) > alert_type: 1, app_feedback_type: 0, popup_view_style: 0, feedback_pattern_app: -1
06-18 20:36:59.557+0200 W/wnotibp ( 3533): wnotiboard-popup-data.c: _data_get_alert_list(307) > ::DATA:: read alert list : 0, new_list count : 1
06-18 20:36:59.557+0200 W/wnotibp ( 3533): wnotiboard-popup-control.c: _ctrl_notification_change_cb(604) > [1,16869]
06-18 20:36:59.562+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 14
06-18 20:36:59.562+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-18 20:36:59.567+0200 I/wnotibp ( 3533): wnotiboard-popup-common.c: _common_app_id_from_win(152) > 802
06-18 20:36:59.602+0200 I/wnotibp ( 3533): wnotiboard-popup-control.c: _ctrl_check_env_condition(441) > focus app is com.samsung.w-home, 0
06-18 20:36:59.602+0200 W/wnotibp ( 3533): wnotiboard-popup-manager.c: wnbp_mgr_add_notification(990) > Add noti_queue [16869, 0]
06-18 20:36:59.602+0200 I/wnotibp ( 3533): wnotiboard-popup-data.c: wnbp_data_free_alert_data_by_db_id(664) > ::DATA:: remove notification data, 16867
06-18 20:36:59.602+0200 I/wnotibp ( 3533): wnotiboard-popup-data.c: wnbp_data_free_alert_data_by_db_id(683) > ::DATA:: CHECK DATA : 1
06-18 20:36:59.602+0200 W/wnotibp ( 3533): wnotiboard-popup-manager.c: _mgr_popup_draw_idler_cb(72) > ::APP:: CHECK STATE : 10, 0, (null)
06-18 20:36:59.602+0200 W/wnotibp ( 3533): wnotiboard-popup-manager.c: wnbp_mgr_get_view_lock_state(665) > ::UI:: lock state=0000
06-18 20:36:59.602+0200 W/wnotibp ( 3533): wnotiboard-popup-manager.c: _mgr_popup_draw_idler_cb(78) > ::APP:: CHECK DATA : 1 1 0000
06-18 20:36:59.602+0200 W/wnotibp ( 3533): wnotiboard-popup-manager.c: _mgr_popup_draw_idler_cb(135) > Set pending noti db_id(16869) 0x45ccce60
06-18 20:36:59.607+0200 I/wnotibp ( 3533): wnotiboard-popup-common.c: wnbp_common_get_block_mode(531) > Returning false.
06-18 20:36:59.607+0200 I/wnotibp ( 3533): wnotiboard-popup-control.c: _ctrl_play_feedback(282) > alert_type : 1, is_source_companion: 1, is_do_not_disturb: 0
06-18 20:36:59.607+0200 W/TIZEN_N_RECORDER( 3533): recorder_product.c: recorder_is_in_recording(82) > pid =/proc/0 , state =0, alive=0
06-18 20:36:59.607+0200 W/wnotibp ( 3533): wnotiboard-popup-control.c: _ctrl_play_feedback(296) > ::APP:: application_id: 52418, is_disaster: 0, disaster_info: (null), app_feedback_type: 0, feedback_pattern_app: -1, is_recording: 0
06-18 20:36:59.607+0200 I/wnotibp ( 3533): wnotiboard-popup-control.c: _ctrl_play_feedback(305) > Gear side feedback setting is_sound_on: 0, is_vibration_on: 1, is_vibrate_when_noti_on: 0
06-18 20:36:59.607+0200 W/wnotibp ( 3533): wnotiboard-popup-control.c: _ctrl_play_feedback(339) > ::APP:: Determined feedback: sound 0, vibration: 0
06-18 20:36:59.607+0200 I/wnotibp ( 3533): wnotiboard-popup-control.c: _ctrl_play_feedback(346) > No feedback.
06-18 20:36:59.607+0200 W/wnotibp ( 3533): wnotiboard-popup-control.c: _ctrl_set_smart_relay(505) > Set the smart relay for 1, 9036, 52418, franceinfo
06-18 20:36:59.607+0200 E/wnoti-proxy( 3533): wnoti.c: wnoti_set_smart_relay(1150) > smart_relay setting : 0
06-18 20:36:59.607+0200 I/wnotibp ( 3533): wnotiboard-popup-common.c: wnbp_common_get_block_mode(531) > Returning false.
06-18 20:36:59.607+0200 W/wnotibp ( 3533): wnotiboard-popup-control.c: _ctrl_turn_on_lcd(538) > [1, 0, 0, 0]
06-18 20:36:59.612+0200 E/wnoti-proxy(  802): wnoti-client.c: _wnoti_parse_extra_sub(372) > JSON_IS_NULL
06-18 20:36:59.612+0200 I/wnoti-proxy(  802): wnoti-client.c: is_mini_app(1795) > is_mini_app : 0
06-18 20:36:59.612+0200 E/wnoti-proxy(  802): wnoti-client.c: _wnoti_parse_android_wear_noti_extender(444) > custom_texts_len : 2
06-18 20:36:59.612+0200 I/wnoti-proxy(  802): wnoti-client.c: is_mini_app(1795) > is_mini_app : 0
06-18 20:36:59.612+0200 I/wnoti-proxy(  802): wnoti-client.c: is_mini_app(1795) > is_mini_app : 0
06-18 20:36:59.612+0200 I/wnoti-proxy(  802): wnoti-client.c: is_mini_app(1795) > is_mini_app : 0
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(482) > unread_count: 1
06-18 20:36:59.617+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_add_category_data(184) > category_id: 8971, application_id: 102, application_name: email application, time_stamp: 1497344603, content_id: 0, spannable_string_version: 0, disble_block_app_action: 0, support_large_icon: 0, android_app_color: 0
06-18 20:36:59.617+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_add_category_data(213) > error_code: 0, string_val: (null)
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(520) > noti_type [1]
06-18 20:36:59.617+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: wnb_nm_add_detail_data(85) > noti_type: 1, application_id: 102, application_name: email application, category_id: 8971, spannable_string_version: 0
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(60) > db_id: 16623, noti_type: 1
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(86) > is_source_companion: 1, content_id: 0, notification_id: 0
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(482) > unread_count: 1
06-18 20:36:59.617+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_add_category_data(184) > category_id: 9031, application_id: 44396, application_name: Clean Master, time_stamp: 1497789365, content_id: 0, spannable_string_version: 1, disble_block_app_action: 0, support_large_icon: 0, android_app_color: 0
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(520) > noti_type [1]
06-18 20:36:59.617+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: wnb_nm_add_detail_data(85) > noti_type: 1, application_id: 44396, application_name: Clean Master, category_id: 9031, spannable_string_version: 1
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(60) > db_id: 16833, noti_type: 1
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(86) > is_source_companion: 1, content_id: 0, notification_id: 256
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(482) > unread_count: 1
06-18 20:36:59.617+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_add_category_data(184) > category_id: 9032, application_id: 214, application_name: Samsung Health, time_stamp: 1497789620, content_id: 0, spannable_string_version: 1, disble_block_app_action: 0, support_large_icon: 0, android_app_color: 0
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(520) > noti_type [1]
06-18 20:36:59.617+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: wnb_nm_add_detail_data(85) > noti_type: 1, application_id: 214, application_name: Samsung Health, category_id: 9032, spannable_string_version: 1
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(60) > db_id: 16834, noti_type: 1
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(86) > is_source_companion: 1, content_id: 0, notification_id: 1931207871
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(482) > unread_count: 1
06-18 20:36:59.617+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_add_category_data(184) > category_id: 9034, application_id: 223, application_name: WhatsApp, time_stamp: 1497808710, content_id: 0, spannable_string_version: 1, disble_block_app_action: 0, support_large_icon: 1, android_app_color: -16294316
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(520) > noti_type [1]
06-18 20:36:59.617+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: wnb_nm_add_detail_data(85) > noti_type: 1, application_id: 223, application_name: WhatsApp, category_id: 9034, spannable_string_version: 1
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(60) > db_id: 16847, noti_type: 1
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(86) > is_source_companion: 1, content_id: 0, notification_id: 7
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(470) > Activity fetch finished: -1
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(475) > activity action count: 2
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(480) > 2 activities retrieved.
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(482) > unread_count: 1
06-18 20:36:59.617+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_add_category_data(184) > category_id: 9036, application_id: 52418, application_name: franceinfo, time_stamp: 1497811017, content_id: 0, spannable_string_version: 1, disble_block_app_action: 0, support_large_icon: 0, android_app_color: 0
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(520) > noti_type [1]
06-18 20:36:59.617+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: wnb_nm_add_detail_data(85) > noti_type: 1, application_id: 52418, application_name: franceinfo, category_id: 9036, spannable_string_version: 1
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(60) > db_id: 16869, noti_type: 1
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(86) > is_source_companion: 1, content_id: 0, notification_id: 1037
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(470) > Activity fetch finished: -1
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(475) > activity action count: 1
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(480) > 1 activities retrieved.
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(667) > New noti is here. Add it on panel  9036, franceinfo.
06-18 20:36:59.617+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_add_card(331) > db_id: 16869, application_id: 52418, application_name: franceinfo
06-18 20:36:59.617+0200 I/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5089) > New event with category_id: 9036, application_id: 52418, type: 1
06-18 20:36:59.657+0200 I/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5427) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
06-18 20:36:59.657+0200 I/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5089) > New event with category_id: 8971, application_id: 102, type: 13
06-18 20:36:59.657+0200 W/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5498) > notiboard panel creation count [12], notiboard card appending count [41].
06-18 20:36:59.657+0200 I/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5089) > New event with category_id: 9031, application_id: 44396, type: 13
06-18 20:36:59.657+0200 W/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5498) > notiboard panel creation count [12], notiboard card appending count [41].
06-18 20:36:59.657+0200 I/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5089) > New event with category_id: 9032, application_id: 214, type: 13
06-18 20:36:59.657+0200 W/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5498) > notiboard panel creation count [12], notiboard card appending count [41].
06-18 20:36:59.657+0200 I/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5089) > New event with category_id: 9034, application_id: 223, type: 13
06-18 20:36:59.657+0200 W/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5498) > notiboard panel creation count [12], notiboard card appending count [41].
06-18 20:36:59.657+0200 I/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5089) > New event with category_id: 9036, application_id: 52418, type: 13
06-18 20:36:59.657+0200 W/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5498) > notiboard panel creation count [12], notiboard card appending count [41].
06-18 20:36:59.662+0200 I/wnotib  (  802): w-notification-board-common.c: wnotib_common_get_application_icon(2401) > application_id: 52418, thumbnail path: /opt/usr/data/wnoti/.app_icon_52418.png, summary_large_image path: (null), width: 58, height: 58
06-18 20:36:59.692+0200 W/APP_CORE( 3533): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:740000a
06-18 20:36:59.697+0200 I/wnotib  (  802): w-notification-board-common.c: wnb_common_add_badge(2626) > badge is unused.
06-18 20:36:59.717+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(702) > This noti will be removed from panel: 9036, franceinfo.
06-18 20:36:59.717+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_remove_card(409) > db_id: 16867, application_id: 52418, application_name: franceinfo
06-18 20:36:59.717+0200 I/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5089) > New event with category_id: 9036, application_id: 52418, type: 2
06-18 20:36:59.717+0200 I/wnotib  (  802): w-notification-board-basic-panel.c: _wnotib_basic_panel_delete_card(3616) > We don't need to delete the item for second_depth_type: 0.
06-18 20:36:59.727+0200 E/EFL     (  802): elementary<802> elm_genlist.c:6331 elm_genlist_items_count() obj ((nil)) is NULL or type is not correct
06-18 20:36:59.727+0200 I/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5089) > New event with category_id: 8971, application_id: 102, type: 12
06-18 20:36:59.727+0200 I/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5089) > New event with category_id: 9031, application_id: 44396, type: 12
06-18 20:36:59.727+0200 I/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5089) > New event with category_id: 9032, application_id: 214, type: 12
06-18 20:36:59.727+0200 I/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5089) > New event with category_id: 9034, application_id: 223, type: 12
06-18 20:36:59.727+0200 I/wnotib  (  802): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5089) > New event with category_id: 9036, application_id: 52418, type: 12
06-18 20:36:59.727+0200 I/wnotib  (  802): w-notification-board-common.c: wnotib_common_get_application_icon(2401) > application_id: 52418, thumbnail path: /opt/usr/data/wnoti/.app_icon_52418.png, summary_large_image path: (null), width: 58, height: 58
06-18 20:36:59.732+0200 I/wnotib  (  802): w-notification-board-common.c: wnb_common_add_badge(2626) > badge is unused.
06-18 20:36:59.742+0200 I/wnotibp ( 3533): wnotiboard-popup-control.c: _ctrl_service_changed_cb(241) > Handle this change type in idler.
06-18 20:36:59.747+0200 W/wnotibp ( 3533): wnotiboard-popup-manager.c: _mgr_x_event_visibility_changed_cb(262) > fully_obscured: 0, 0
06-18 20:36:59.747+0200 I/wnotibp ( 3533): wnotiboard-popup-manager.c: _mgr_x_event_visibility_changed_cb(263) > [0x740000a 0x740000a 0x7400008]
06-18 20:36:59.747+0200 I/APP_CORE( 3533): appcore-efl.c: __visibility_cb(937) > LCD status is off, skip the AE_RESUME event
06-18 20:36:59.757+0200 W/AUL     (  504): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(802) status(bg) type(uiapp)
06-18 20:36:59.757+0200 W/STARTER (  769): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[802] goes to (4)
06-18 20:36:59.757+0200 E/STARTER (  769): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 802)'s state(4)
06-18 20:36:59.757+0200 W/STARTER (  769): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[3533] goes to (3)
06-18 20:36:59.757+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-18 20:36:59.757+0200 W/AUL_AMD (  504): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
06-18 20:36:59.757+0200 W/AUL     (  504): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.wnotiboard-popup) pid(3533) status(fg) type(uiapp)
06-18 20:36:59.782+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(712) > Num categories: 5, num total noti: 5
06-18 20:36:59.782+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_free_data(240) > Free noti manager data.
06-18 20:36:59.782+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_free_data(245) > Free previous notifications.
06-18 20:36:59.782+0200 I/MALI    ( 3533): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x45c079b0] swap changed from async to sync
06-18 20:36:59.782+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_free_data(266) > Free previous categories.
06-18 20:36:59.782+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(735) > before_rpanel_count: 5, after_rpanel_count: 5.
06-18 20:36:59.782+0200 W/W_HOME  (  802): noti_broker.c: _handler_indicator_update(560) > 0x5
06-18 20:36:59.957+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: wnb_nm_control_home_indicator(53) > Show home indicator.
06-18 20:36:59.962+0200 W/W_HOME  (  802): noti_broker.c: _handler_noti_indicator_show(476) > 
06-18 20:36:59.967+0200 W/W_HOME  (  802): noti_broker.c: _noti_indicator_visible_get(205) > cooldownmode:0 visible:0
06-18 20:36:59.967+0200 W/W_HOME  (  802): noti_broker.c: _handler_noti_indicator_show(484) > not a visible state
06-18 20:36:59.972+0200 W/W_HOME  (  802): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
06-18 20:36:59.977+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:36:59.977+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:36:59.982+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:36:59.982+0200 W/W_INDICATOR(  796): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
06-18 20:36:59.982+0200 W/W_HOME  (  802): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
06-18 20:36:59.982+0200 W/W_HOME  (  802): event_manager.c: _window_visibility_cb(466) > Window [0x2800003] is now visible(1)
06-18 20:36:59.982+0200 W/W_HOME  (  802): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
06-18 20:36:59.982+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:36:59.982+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:36:59.982+0200 E/W_HOME  (  802): win.c: win_rotation_disable_set(186) > failed to get key VCONFKEY_DISABLE_ROTATION
06-18 20:36:59.982+0200 W/W_HOME  (  802): main.c: _window_visibility_cb(963) > Window [0x2800003] is now visible(1)
06-18 20:36:59.987+0200 I/APP_CORE(  802): appcore-efl.c: __do_app(453) > [APP 802] Event: PAUSE State: PAUSED
06-18 20:36:59.987+0200 I/APP_CORE(  802): appcore-efl.c: __visibility_cb(949) > LCD status is off, skip the AE_RESUME event
06-18 20:36:59.987+0200 I/wnotib  (  802): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
06-18 20:36:59.987+0200 E/wnotib  (  802): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-18 20:36:59.987+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [12], notiboard card appending count [41].
06-18 20:36:59.992+0200 W/W_INDICATOR(  796): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-18 20:36:59.997+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_data_changed_cb(787) > Change type : 0, op_type: 0, category_id: 0, display count: 0
06-18 20:36:59.997+0200 I/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_data_changed_cb(821) > Handle this change type in idler.
06-18 20:36:59.997+0200 W/wnotib  (  802): w-notification-board-noti-manager.c: _wnb_nm_data_changed_cb(825) > Postpone notiboard update.
06-18 20:37:00.007+0200 E/wnoti-service( 1154): wnoti-db-client.c: wnoti_get_alert_categories(997) > _query_step failed(NO ROW)
06-18 20:37:00.012+0200 E/wnoti-service( 1154): wnoti-db-utility.c: set_pm_lock(583) > >> set_pm_lock status : 2
06-18 20:37:00.017+0200 E/wnoti-service( 1154): wnoti-db-utility.c: unlock_pm(614) > >> unlock_pm status : 0
06-18 20:37:00.027+0200 E/wnoti-proxy( 3533): wnoti.c: _wnoti_get_categories(1268) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
06-18 20:37:00.027+0200 E/wnotibp ( 3533): wnotiboard-popup-data.c: _data_get_alert_list(304) > ::DATA:: No categories available.
06-18 20:37:00.027+0200 W/wnotibp ( 3533): wnotiboard-popup-data.c: _data_get_alert_list(307) > ::DATA:: read alert list : 1, new_list count : 0
06-18 20:37:01.772+0200 I/AUL_PAD ( 6880): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
06-18 20:37:02.267+0200 I/watchface-viewer(  937): viewer-data-provider.cpp: AddPendingChanges(2230) > added [50] to pending list
06-18 20:37:03.037+0200 I/APP_CORE(  802): appcore-efl.c: __do_app(453) > [APP 802] Event: MEM_FLUSH State: PAUSED
06-18 20:37:09.802+0200 W/CRASH_MANAGER( 6749): worker.c: worker_job(1205) > 110686673636f149781101
