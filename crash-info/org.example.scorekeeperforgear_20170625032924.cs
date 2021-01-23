S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.2
Build-Number: R732XXU2EQC1
Build-Date: 2017.03.13 20:32:41

Crash Information
Process Name: scorekeeperforgear
PID: 14079
Date: 2017-06-25 03:29:24+0200
Executable File Path: /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x4

Register Information
r0   = 0x00000000, r1   = 0x418ba5ac
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xbee6a4c0, r5   = 0x41492980
r6   = 0x00000274, r7   = 0xbee69c48
r8   = 0x4139a310, r9   = 0x000036ff
r10  = 0x417b6210, fp   = 0x00000000
ip   = 0x418cbd8c, sp   = 0xbee69c40
lr   = 0x418b5991, pc   = 0x418b9c8e
cpsr = 0x20000030

Memory Information
MemTotal:   491132 KB
MemFree:      9764 KB
Buffers:      7444 KB
Cached:      94476 KB
VmPeak:      95576 KB
VmSize:      95572 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18868 KB
VmRSS:       18864 KB
VmData:      35988 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23316 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 14079 TID = 14079
14079 14144 14145 

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
414be000 414c9000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
414d4000 414d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
414e1000 414e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
414ec000 414f2000 r-xp /usr/lib/libappsvc.so.0.1.0
414fa000 4151e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41527000 415f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4160c000 41616000 r-xp /lib/libnss_files-2.13.so
418b2000 418bc000 r-xp /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
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
43bbf000 43bca000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43bd3000 43bd8000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43be0000 43bf7000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c04000 43c06000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
4440e000 4440f000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
445d6000 44e00000 rw-p [stack:14144]
45173000 45d25000 rw-p [stack:14145]
bee4a000 bee6b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14079)
Call Stack Count: 19
 0: SensorProcess::getSensorValue() + 0x65 (0x418b9c8e) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x7c8e
 1: app_resume(void*) + 0x1c (0x418b5991) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x3991
 2: (0x41491bf9) [/usr/lib/libcapi-appfw-application.so.0] + 0x1bf9
 3: (0x400441ed) [/usr/lib/libappcore-efl.so.1] + 0x31ed
 4: (0x414a7d1f) [/usr/lib/libappcore-common.so.1] + 0x1d1f
 5: (0x4005a495) [/usr/lib/libaul.so.0] + 0x4495
 6: (0x4005afad) [/usr/lib/libaul.so.0] + 0x4fad
 7: (0x403bbfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 8: g_main_context_dispatch + 0xbc (0x403bd7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 9: (0x40302ca7) [/usr/lib/libecore.so.1] + 0x10ca7
10: (0x402fdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
11: (0x402fe4d5) [/usr/lib/libecore.so.1] + 0xc4d5
12: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
13: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
14: ui_app_main + 0xb0 (0x41492421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
15: main + 0xc2 (0x418b56eb) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x36eb
16:  + 0x0 (0x40001a53) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x1a53
17: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
18: (0x40001e0c) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x1e0c
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
agePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 03:29:23.894+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-25 03:29:23.894+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-25 03:29:23.894+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 03:29:23.894+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-25 03:29:23.894+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 03:29:23.909+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,580709)
06-25 03:29:23.914+0200 I/wnotib  (  840): w-notification-board-basic-panel.c: _wnb_basic_panel_activate(3337) > page_index: 2.
06-25 03:29:23.914+0200 W/W_HOME  (  840): noti_broker.c: _handler_indicator_select(579) > 2
06-25 03:29:23.914+0200 W/W_HOME  (  840): noti_broker.c: _handler_indicator_select(589) > select index:3
06-25 03:29:23.914+0200 W/W_HOME  (  840): noti_broker.c: _handler_indicator_show(539) > 
06-25 03:29:23.914+0200 W/W_HOME  (  840): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
06-25 03:29:23.914+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3390), py(0)
06-25 03:29:23.914+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,580709)
06-25 03:29:23.914+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3390), py(0)
06-25 03:29:23.924+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,634123)
06-25 03:29:23.924+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3371), py(0)
06-25 03:29:23.924+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,634123)
06-25 03:29:23.924+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3371), py(0)
06-25 03:29:23.929+0200 W/AUL_PAD (14079): launchpad_loader.c: main(690) > [candidate] dlsym
06-25 03:29:23.929+0200 W/AUL_PAD (14079): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.scorekeeperforgear)
06-25 03:29:23.944+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,717100)
06-25 03:29:23.944+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3341), py(0)
06-25 03:29:23.944+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,717100)
06-25 03:29:23.944+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3341), py(0)
06-25 03:29:23.944+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-25 03:29:23.944+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-25 03:29:23.944+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 03:29:23.944+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-25 03:29:23.944+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-25 03:29:23.944+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 03:29:23.944+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-25 03:29:23.944+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-25 03:29:23.944+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-25 03:29:23.944+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 03:29:23.949+0200 W/MUSIC_CONTROL_SERVICE( 1257): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1257]   [MUSIC_PLAYER_EVENT][0m
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-25 03:29:23.959+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 03:29:23.964+0200 W/W_HOME  (  840): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
06-25 03:29:23.964+0200 E/W_HOME  (  840): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-25 03:29:23.964+0200 W/W_HOME  (  840): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
06-25 03:29:23.964+0200 E/W_HOME  (  840): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-25 03:29:23.964+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,799435)
06-25 03:29:23.969+0200 E/WMS     (  514): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[gQufQ4tHCi], Appname[Filesmaster Standalone]
06-25 03:29:23.979+0200 I/CAPI_APPFW_APPLICATION(14079): app_main.c: ui_app_main(704) > app_efl_main
06-25 03:29:23.979+0200 E/RESOURCED(  598): block-monitor.c: block_logging(123) > pid 14079(org.example.scorekeeperforgear) accessed /opt/usr/media/Documents/config.cfg
06-25 03:29:23.984+0200 I/CAPI_APPFW_APPLICATION(14079): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
06-25 03:29:23.994+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3312), py(0)
06-25 03:29:23.994+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,799435)
06-25 03:29:23.994+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3312), py(0)
06-25 03:29:24.009+0200 W/AUL     (  506): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.scorekeeperforgear) pid(14079) type(uiapp) bg(0)
06-25 03:29:24.014+0200 W/AUL_AMD (  506): amd_status.c: __socket_monitor_cb(1277) > (14079) was created
06-25 03:29:24.014+0200 W/AUL     (14142): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14079)
06-25 03:29:24.039+0200 W/STARTER (  755): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [14079]
06-25 03:29:24.039+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,973693)
06-25 03:29:24.044+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3249), py(0)
06-25 03:29:24.044+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,973693)
06-25 03:29:24.044+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3249), py(0)
06-25 03:29:24.064+0200 E/WMS     (  514): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[m9Sb04ZlB7], Appname[Yelp]
06-25 03:29:24.099+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,998251)
06-25 03:29:24.099+0200 E/WMS     (  514): wms_package_manager.c: get_watch_app_info(803) > SAP Setting File Path: /opt/usr/apps/oQbQH11Tzv/res/wgt/res/xml/accessoryservices.xml
06-25 03:29:24.104+0200 E/WMS     (  514): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[oQbQH11Tzv], Appname[Running]
06-25 03:29:24.104+0200 W/wnotib  (  840): w-notification-board-broker-main.c: wnotib_main_dismiss_confirmation_popup(1427) > 
06-25 03:29:24.104+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_CANCEL : px(3240), py(0)
06-25 03:29:24.104+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,998251)
06-25 03:29:24.104+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] animation stop!!
06-25 03:29:24.104+0200 W/wnotib  (  840): w-notification-board-panel-manager.c: _wnb_pm_anim_stop_cb(96) > notiboard scroller anim stop [3240][0][360][360]
06-25 03:29:24.129+0200 W/wnotib  (  840): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(969) > No postponed update with is_for_VI: 1.
06-25 03:29:24.129+0200 W/W_HOME  (  840): home_navigation.c: _anim_stop_cb(1316) > anim stop
06-25 03:29:24.134+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 03:29:24.134+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
06-25 03:29:24.134+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-25 03:29:24.139+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(489) > [0x46056f58 : elm_scroller] detent_count(-1)
06-25 03:29:24.139+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(490) > [0x46056f58 : elm_scroller] pagenumber_v(0), pagenumber_h(9)
06-25 03:29:24.139+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(512) > [0x46056f58 : elm_scroller] CurrentPage(9)
06-25 03:29:24.139+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_CANCEL : px(3240), py(0)
06-25 03:29:24.139+0200 E/WMS     (  514): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[org.example.basicuiwithedc2], Appname[basicuiwithedc2]
06-25 03:29:24.149+0200 E/rpm-installer(14069): rpm-appcore-intf.c: main(273) > ------------------------------------------------
06-25 03:29:24.154+0200 E/rpm-installer(14069): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
06-25 03:29:24.154+0200 E/rpm-installer(14069): rpm-appcore-intf.c: main(275) > ------------------------------------------------
06-25 03:29:24.189+0200 E/PKGMGR_SERVER(14014): pkgmgr-server.c: sighandler(486) > child NORMAL exit [14069]
06-25 03:29:24.194+0200 E/RESOURCED(  598): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/14069/oom_score_adj failed
06-25 03:29:24.194+0200 E/RESOURCED(  598): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 14069
06-25 03:29:24.244+0200 E/W_HOME  (  840): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
06-25 03:29:24.244+0200 E/EFL     (  840): edje<840> edje_util.c:3785 edje_object_size_min_restricted_calc() group page has a non-fixed part 'bg'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-25 03:29:24.244+0200 E/EFL     (  840): edje<840> edje_util.c:3785 edje_object_size_min_restricted_calc() group page has a non-fixed part 'bg'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-25 03:29:24.244+0200 E/EFL     (  840): edje<840> edje_util.c:3788 edje_object_size_min_restricted_calc() group page overflowed 4000x4000 with minimum size of 4320x360. Continuing discarding faulty parts.
06-25 03:29:24.244+0200 E/WMS     (  514): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[org.example.scorekeeperforgear], Appname[scorekeeperforgear]
06-25 03:29:24.274+0200 E/WMS     (  514): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[org.example.stopwatch], Appname[stopwatch]
06-25 03:29:24.274+0200 I/efl-extension(14079): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1242) > Put the surface[0x417ef7a8]'s widget[0x417fb910] to elm_conformant widget[0x41456d40]
06-25 03:29:24.274+0200 I/efl-extension(14079): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
06-25 03:29:24.274+0200 W/WRT_PLUGINS/TIZEN(17384): SystemInfoCpu.cpp: fetchLoad(76) > Cannot calculate cpu load, previous value returned
06-25 03:29:24.279+0200 W/W_HOME  (  840): event_manager.c: _home_scroll_cb(585) > scroll,will,done
06-25 03:29:24.279+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:24.279+0200 W/W_HOME  (  840): event_manager.c: _home_scroll_cb(585) > scroll,done
06-25 03:29:24.279+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:24.289+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_add(1990) > called!!
06-25 03:29:24.304+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: _eext_rotary_selector_data_init(586) > rsd is initialized!!
06-25 03:29:24.309+0200 E/WMS     (  514): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[org.example.uicomponents], Appname[uicomponents]
06-25 03:29:24.344+0200 E/WMS     (  514): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[org.tizen.filetransfersender], Appname[FileTransferSender]
06-25 03:29:24.374+0200 E/WMS     (  514): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[org.tizen.hellomessageconsumer], Appname[HelloMessageConsumer]
06-25 03:29:24.379+0200 I/efl-extension(14079): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
06-25 03:29:24.379+0200 I/efl-extension(14079): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
06-25 03:29:24.379+0200 I/efl-extension(14079): efl_extension_rotary.c: _init_Xi2_system(314) > In
06-25 03:29:24.379+0200 I/efl-extension(14079): efl_extension_rotary.c: _init_Xi2_system(375) > Done
06-25 03:29:24.379+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: _event_area_callback_add(500) > called!!
06-25 03:29:24.379+0200 I/efl-extension(14079): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x417fcc28, elm_layout, _activated_obj : 0x0, activated : 1
06-25 03:29:24.379+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 03:29:24.404+0200 E/WMS     (  514): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[org.tizen.tizenseckeystring], Appname[Tizen Keystring]
06-25 03:29:24.419+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 03:29:24.419+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 03:29:24.419+0200 E/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 03:29:24.419+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 03:29:24.424+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 03:29:24.424+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 03:29:24.424+0200 E/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 03:29:24.424+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 03:29:24.429+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 03:29:24.429+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 03:29:24.429+0200 E/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 03:29:24.429+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 03:29:24.434+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 03:29:24.434+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 03:29:24.434+0200 E/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 03:29:24.434+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 03:29:24.444+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 03:29:24.444+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 03:29:24.444+0200 E/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 03:29:24.444+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 03:29:24.454+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 03:29:24.454+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 03:29:24.454+0200 E/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 03:29:24.454+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 03:29:24.459+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 03:29:24.459+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 03:29:24.459+0200 E/efl-extension(14079): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 03:29:24.474+0200 E/EFL     (14079): elementary<14079> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
06-25 03:29:24.489+0200 E/EFL     (14079): elementary<14079> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44466c00) will be pushed
06-25 03:29:24.509+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: _rotary_selector_show_cb(805) > called!!
06-25 03:29:24.519+0200 I/efl-extension(14079): efl_extension_rotary_selector.c: _rotary_selector_move_cb(776) > called!!
06-25 03:29:24.529+0200 I/APP_CORE(14079): appcore-efl.c: __do_app(453) > [APP 14079] Event: RESET State: CREATED
06-25 03:29:24.529+0200 I/CAPI_APPFW_APPLICATION(14079): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
06-25 03:29:24.539+0200 I/efl-extension( 1583): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 03:29:24.539+0200 I/efl-extension(  840): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 03:29:24.539+0200 I/efl-extension(  840): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x46070c68, elm_box, time_stamp : 15995724
06-25 03:29:24.539+0200 I/wnotib  (  840): w-notification-board-broker-main.c: _wnotib_rotary_cb(559) > Pass rotary event to home.
06-25 03:29:24.539+0200 I/efl-extension(13314): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 03:29:24.539+0200 W/W_HOME  (  840): home_navigation.c: _rotary_cb(1168) > Detent detected, obj[0x46056f58], direction[0]
06-25 03:29:24.539+0200 I/efl-extension(17373): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 03:29:24.544+0200 I/efl-extension(13400): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 03:29:24.549+0200 E/CAPI_TELEPHONY(  514): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-25 03:29:24.564+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 03:29:24.564+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
06-25 03:29:24.564+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-25 03:29:24.564+0200 W/W_HOME  (  840): home_navigation.c: _is_rightedge(187) > (3240 360) not right edge: -3240 0 0x4889e528 -> 1080 0 0x46a0a4e8
06-25 03:29:24.564+0200 E/EFL     (  840): edje<840> edje_util.c:3785 edje_object_size_min_restricted_calc() group page has a non-fixed part 'bg'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-25 03:29:24.564+0200 E/EFL     (  840): edje<840> edje_util.c:3785 edje_object_size_min_restricted_calc() group page has a non-fixed part 'bg'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-25 03:29:24.564+0200 E/EFL     (  840): edje<840> edje_util.c:3788 edje_object_size_min_restricted_calc() group page overflowed 4000x4000 with minimum size of 4320x360. Continuing discarding faulty parts.
06-25 03:29:24.589+0200 I/APP_CORE(14079): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
06-25 03:29:24.589+0200 I/APP_CORE(14079): appcore-efl.c: __do_app(524) > [APP 14079] Initial Launching, call the resume_cb
06-25 03:29:24.589+0200 I/CAPI_APPFW_APPLICATION(14079): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
06-25 03:29:24.634+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(633) > [0x46056f58 : elm_scroller] rotary callabck is called.
06-25 03:29:24.634+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(663) > [0x46056f58 : elm_scroller] block(2)
06-25 03:29:24.634+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(664) > [0x46056f58 : elm_scroller] scroll_locked_x(0), scroll_locked_y(0)
06-25 03:29:24.634+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(665) > [0x46056f58 : elm_scroller] content size (w, h)(9360, 360)
06-25 03:29:24.634+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(666) > [0x46056f58 : elm_scroller] viewport size (w, h)(360, 360)
06-25 03:29:24.634+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(730) > [0x46056f58 : elm_scroller] CurrentPage(9) DetentValue(1)
06-25 03:29:24.634+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(731) > [0x46056f58 : elm_scroller] DetentCount(0)
06-25 03:29:24.634+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056f58 : elm_scroller] mx(9000), my(0), minx(0), miny(0), px(3240), py(0)
06-25 03:29:24.634+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056f58 : elm_scroller] mx(9000), my(0), minx(0), miny(0), px(3240), py(0)
06-25 03:29:24.634+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056f58 : elm_scroller] mx(9000), my(0), minx(0), miny(0), px(3240), py(0)
06-25 03:29:24.634+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(763) > [0x46056f58 : elm_scroller] bring in 10 page
06-25 03:29:24.634+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:5560 _elm_scroll_page_bring_in() [0x46056f58 : elm_scroller] pagenumber_h(10), pagenumber_v(0)
06-25 03:29:24.634+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x46056f58 : elm_scroller] mx(9000), my(0), minx(0), miny(0), px(3240), py(0)
06-25 03:29:24.634+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x46056f58 : elm_scroller] cw(9360), ch(360), pw(360), ph(360)
06-25 03:29:24.634+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x46056f58 : elm_scroller] x(3600), y(0), nx(3600), px(3240), ny(0) py(0)
06-25 03:29:24.634+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x46056f58 : elm_scroller] x(3600), y(0)
06-25 03:29:24.634+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:5578 _elm_scroll_page_bring_in() [0x46056f58 : elm_scroller] _elm_scroll_content_region_show_internal() return TRUE!! x(3600), y(0)
06-25 03:29:24.634+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x46056f58 : elm_scroller] t_in(0,270000), pos_x(3600)
06-25 03:29:24.634+0200 W/W_HOME  (  840): home_navigation.c: _anim_start_cb(1290) > anim start
06-25 03:29:24.634+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 03:29:24.639+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x46056f58 : elm_scroller] t_in(0,270000), pos_y(0)
06-25 03:29:24.639+0200 W/W_HOME  (  840): event_manager.c: _home_scroll_cb(585) > scroll,will,start
06-25 03:29:24.639+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 2, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:24.639+0200 W/W_HOME  (  840): event_manager.c: _home_scroll_cb(585) > scroll,start
06-25 03:29:24.639+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:24.659+0200 I/MALI    (  840): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf0f0] swap changed from sync to async
06-25 03:29:24.674+0200 W/W_HOME  (  840): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
06-25 03:29:24.674+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:24.674+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:24.674+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:24.674+0200 W/W_HOME  (  840): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
06-25 03:29:24.674+0200 W/W_INDICATOR(  756): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
06-25 03:29:24.674+0200 W/W_HOME  (  840): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
06-25 03:29:24.674+0200 W/W_INDICATOR(  756): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-25 03:29:24.689+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,753910)
06-25 03:29:24.689+0200 I/wnotib  (  840): w-notification-board-basic-panel.c: _wnb_basic_panel_activate(3337) > page_index: 1.
06-25 03:29:24.689+0200 W/W_HOME  (  840): noti_broker.c: _handler_indicator_select(579) > 1
06-25 03:29:24.689+0200 W/W_HOME  (  840): noti_broker.c: _handler_indicator_select(589) > select index:2
06-25 03:29:24.689+0200 W/W_HOME  (  840): noti_broker.c: _handler_indicator_show(539) > 
06-25 03:29:24.689+0200 W/W_HOME  (  840): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
06-25 03:29:24.689+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3511), py(0)
06-25 03:29:24.689+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,753910)
06-25 03:29:24.689+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3511), py(0)
06-25 03:29:24.724+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,905533)
06-25 03:29:24.729+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3565), py(0)
06-25 03:29:24.729+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,905533)
06-25 03:29:24.729+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3565), py(0)
06-25 03:29:24.744+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,944589)
06-25 03:29:24.749+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3580), py(0)
06-25 03:29:24.749+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,944589)
06-25 03:29:24.749+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3580), py(0)
06-25 03:29:24.764+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,973601)
06-25 03:29:24.769+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3590), py(0)
06-25 03:29:24.769+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,973601)
06-25 03:29:24.769+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3590), py(0)
06-25 03:29:24.779+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,990866)
06-25 03:29:24.784+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3596), py(0)
06-25 03:29:24.784+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,990866)
06-25 03:29:24.784+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3596), py(0)
06-25 03:29:24.799+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,999446)
06-25 03:29:24.804+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3599), py(0)
06-25 03:29:24.804+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,999446)
06-25 03:29:24.804+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(3599), py(0)
06-25 03:29:24.814+0200 E/PKGMGR_SERVER(14014): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
06-25 03:29:24.814+0200 E/PKGMGR_SERVER(14014): pkgmgr-server.c: main(2296) > package manager server terminated.
06-25 03:29:24.819+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,997824)
06-25 03:29:24.824+0200 W/wnotib  (  840): w-notification-board-broker-main.c: wnotib_main_dismiss_confirmation_popup(1427) > 
06-25 03:29:24.824+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_CANCEL : px(3600), py(0)
06-25 03:29:24.824+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,997824)
06-25 03:29:24.824+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] animation stop!!
06-25 03:29:24.829+0200 W/wnotib  (  840): w-notification-board-panel-manager.c: _wnb_pm_anim_stop_cb(96) > notiboard scroller anim stop [3600][0][360][360]
06-25 03:29:24.844+0200 W/wnotib  (  840): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(969) > No postponed update with is_for_VI: 1.
06-25 03:29:24.844+0200 W/W_HOME  (  840): home_navigation.c: _anim_stop_cb(1316) > anim stop
06-25 03:29:24.844+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 03:29:24.844+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
06-25 03:29:24.844+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-25 03:29:24.844+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(489) > [0x46056f58 : elm_scroller] detent_count(1)
06-25 03:29:24.844+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(490) > [0x46056f58 : elm_scroller] pagenumber_v(0), pagenumber_h(10)
06-25 03:29:24.844+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(512) > [0x46056f58 : elm_scroller] CurrentPage(10)
06-25 03:29:24.844+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_CANCEL : px(3600), py(0)
06-25 03:29:24.854+0200 I/efl-extension( 1583): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 03:29:24.854+0200 I/efl-extension(13400): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 03:29:24.854+0200 I/efl-extension(13314): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 03:29:24.874+0200 I/efl-extension(  840): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 03:29:24.879+0200 I/efl-extension(17373): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 03:29:24.964+0200 E/W_HOME  (  840): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
06-25 03:29:24.969+0200 E/EFL     (  840): edje<840> edje_util.c:3785 edje_object_size_min_restricted_calc() group page has a non-fixed part 'bg'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-25 03:29:24.969+0200 E/EFL     (  840): edje<840> edje_util.c:3785 edje_object_size_min_restricted_calc() group page has a non-fixed part 'bg'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-25 03:29:24.969+0200 E/EFL     (  840): edje<840> edje_util.c:3788 edje_object_size_min_restricted_calc() group page overflowed 4000x4000 with minimum size of 4320x360. Continuing discarding faulty parts.
06-25 03:29:24.989+0200 W/W_HOME  (  840): event_manager.c: _home_scroll_cb(585) > scroll,will,done
06-25 03:29:24.989+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:24.994+0200 W/W_HOME  (  840): event_manager.c: _home_scroll_cb(585) > scroll,done
06-25 03:29:24.994+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:25.029+0200 W/AUL_AMD (  506): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-25 03:29:25.029+0200 W/AUL_AMD (  506): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
06-25 03:29:25.174+0200 W/AUL_AMD (  506): amd_request.c: __request_handler(669) > __request_handler: 14
06-25 03:29:25.219+0200 W/AUL_AMD (  506): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-25 03:29:25.219+0200 E/CAPI_APPFW_APP_MANAGER( 1359): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
06-25 03:29:25.219+0200 E/CAPI_APPFW_APP_MANAGER( 1359): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
06-25 03:29:25.249+0200 W/AUL_AMD (  506): amd_request.c: __request_handler(669) > __request_handler: 14
06-25 03:29:25.254+0200 W/AUL_AMD (  506): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-25 03:29:25.269+0200 E/CAPI_APPFW_APP_MANAGER( 1373): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
06-25 03:29:25.269+0200 E/CAPI_APPFW_APP_MANAGER( 1373): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
06-25 03:29:25.279+0200 W/WRT_PLUGINS/TIZEN(17384): SystemInfoCpu.cpp: fetchLoad(76) > Cannot calculate cpu load, previous value returned
06-25 03:29:25.309+0200 W/PROCESSMGR(  461): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
06-25 03:29:25.314+0200 W/W_HOME  (  840): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
06-25 03:29:25.314+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:25.314+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:25.314+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:25.314+0200 W/W_HOME  (  840): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 1
06-25 03:29:25.314+0200 W/W_INDICATOR(  756): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
06-25 03:29:25.314+0200 W/W_INDICATOR(  756): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-25 03:29:25.314+0200 W/WATCH_CORE(  935): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
06-25 03:29:25.314+0200 I/WATCH_CORE(  935): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
06-25 03:29:25.314+0200 I/CAPI_WATCH_APPLICATION(  935): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-25 03:29:25.314+0200 E/watchface-app(  935): watchface.cpp: OnAppTimeTick(744) > 
06-25 03:29:25.314+0200 I/watchface-app(  935): watchface.cpp: OnAppTimeTick(756) > set force update!!
06-25 03:29:25.314+0200 I/watchface-viewer(  935): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
06-25 03:29:25.314+0200 I/watchface-viewer(  935): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 276x63
06-25 03:29:25.319+0200 I/watchface-viewer(  935): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(577) > ImagesLoadingDoneSignal().Emit()
06-25 03:29:25.404+0200 W/AUL_PAD ( 1356): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 14079 pgid = 14079
06-25 03:29:25.404+0200 W/AUL_PAD ( 1356): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
06-25 03:29:25.444+0200 W/W_HOME  (  840): noti_broker.c: _handler_indicator_hide(550) > 
06-25 03:29:25.444+0200 W/W_HOME  (  840): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
06-25 03:29:25.449+0200 W/CRASH_MANAGER(14151): worker.c: worker_job(1205) > 111407973636f149835416
