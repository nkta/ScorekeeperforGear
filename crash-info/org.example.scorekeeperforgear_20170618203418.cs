S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.2
Build-Number: R732XXU2EQC1
Build-Date: 2017.03.13 20:32:41

Crash Information
Process Name: scorekeeperforgear
PID: 5968
Date: 2017-06-18 20:34:18+0200
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
r6   = 0x400193a4, r7   = 0xbef3c270
r8   = 0x4000357d, r9   = 0xfffea3b5
r10  = 0xfffea3f1, fp   = 0xfffea415
ip   = 0x404b4b50, sp   = 0xbef3bfe8
lr   = 0x400063d3, pc   = 0x404b4b58
cpsr = 0x60000010

Memory Information
MemTotal:   491132 KB
MemFree:      9180 KB
Buffers:      9568 KB
Cached:     124556 KB
VmPeak:      55564 KB
VmSize:      55560 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        8704 KB
VmRSS:        8704 KB
VmData:       3328 KB
VmStk:         136 KB
VmExe:          36 KB
VmLib:       22028 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
40000000 40009000 r-xp /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
4000b000 4000f000 r-xp /usr/lib/libsys-assert.so
4001a000 40037000 r-xp /lib/ld-2.13.so
40056000 40058000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40061000 40065000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4006d000 40072000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
4007a000 40086000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
4008f000 40097000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
40098000 4009a000 r-xp /usr/lib/libdlog.so.0.0.0
400a2000 400b9000 r-xp /usr/lib/libecore.so.1.7.99
400d0000 400f1000 r-xp /usr/lib/libefl-extension.so.0.1.0
400f9000 40235000 r-xp /usr/lib/libelementary.so.1.7.99
4024c000 4031a000 r-xp /usr/lib/libevas.so.1.7.99
4033f000 403d3000 r-xp /usr/lib/libstdc++.so.6.0.16
403e6000 4044f000 r-xp /lib/libm-2.13.so
40458000 4057c000 r-xp /lib/libc-2.13.so
4058a000 40592000 r-xp /lib/libgcc_s-4.6.so.1
40593000 4059e000 r-xp /lib/libunwind.so.8.0.1
405cb000 405cd000 r-xp /lib/libdl-2.13.so
405d6000 405e3000 r-xp /usr/lib/libaul.so.0.1.0
405ed000 40610000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
40618000 4062c000 r-xp /lib/libpthread-2.13.so
40637000 4063b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
40644000 4064a000 r-xp /usr/lib/libappcore-efl.so.1.1
40652000 40657000 r-xp /usr/lib/libappcore-common.so.1.1
4065f000 406a0000 r-xp /usr/lib/libeina.so.1.7.99
406a9000 406b2000 r-xp /usr/lib/libvconf.so.0.2.45
406ba000 406bf000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
406c7000 4079a000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
407a5000 407d9000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
407e2000 408b2000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
408b3000 408dd000 r-xp /usr/lib/libsensor.so.1.9.5
408e6000 408ed000 r-xp /usr/lib/libctx-shared.so.0.8.3
408f5000 408fa000 r-xp /usr/lib/libctx-client.so.0.8.3
40902000 40952000 r-xp /usr/lib/libecore_x.so.1.7.99
40954000 40976000 r-xp /usr/lib/libecore_evas.so.1.7.99
4097f000 409a7000 r-xp /usr/lib/libfontconfig.so.1.8.0
409a8000 40a74000 r-xp /usr/lib/libxml2.so.2.7.8
40a81000 40a93000 r-xp /usr/lib/libefl-assist.so.0.1.0
40a9b000 40aa1000 r-xp /lib/librt-2.13.so
40aaa000 40b08000 r-xp /usr/lib/libedje.so.1.7.99
40b12000 40bca000 r-xp /usr/lib/libcairo.so.2.11200.14
40bd5000 40cb6000 r-xp /usr/lib/libX11.so.6.3.0
40cc1000 40cca000 r-xp /usr/lib/libXi.so.6.1.0
40cd2000 40ceb000 r-xp /usr/lib/libeet.so.1.7.99
40cfc000 40d01000 r-xp /usr/lib/libecore_file.so.1.7.99
40d09000 40d1a000 r-xp /usr/lib/libecore_input.so.1.7.99
40d22000 40d2b000 r-xp /usr/lib/libedbus.so.1.7.99
40d33000 40d5d000 r-xp /usr/lib/libdbus-1.so.3.8.12
40d66000 40d80000 r-xp /usr/lib/libecore_con.so.1.7.99
40d89000 40d9c000 r-xp /usr/lib/libfribidi.so.0.3.1
40da4000 40de9000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
40df2000 40e48000 r-xp /usr/lib/libfreetype.so.6.11.3
40e54000 40eaa000 r-xp /usr/lib/libpixman-1.so.0.28.2
40eb7000 40eba000 r-xp /usr/lib/libbundle.so.0.1.22
40ec2000 40ed9000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40ee2000 40ee7000 r-xp /usr/lib/libxdgmime.so.1.1.0
40eef000 40ef0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
40ef8000 40f16000 r-xp /usr/lib/libsystemd.so.0.4.0
40f20000 40f3a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40f42000 40fb7000 r-xp /usr/lib/libsqlite3.so.0.8.6
40fc1000 40fc7000 r-xp /usr/lib/libappsvc.so.0.1.0
40fd0000 40fd6000 r-xp /usr/lib/libecore_imf.so.1.7.99
40fde000 40fe0000 r-xp /usr/lib/libiniparser.so.0
40fe9000 40fea000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40ff2000 40ff7000 r-xp /usr/lib/libffi.so.5.0.10
40fff000 41001000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
4100a000 41020000 r-xp /lib/libz.so.1.2.5
41028000 41038000 r-xp /lib/libresolv-2.13.so
4103c000 41042000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
4104b000 41055000 r-xp /usr/lib/libsensord-shared.so
4105d000 4106c000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41076000 410a5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
410ad000 410b4000 r-xp /usr/lib/libXcursor.so.1.0.2
410bc000 410be000 r-xp /usr/lib/libXdamage.so.1.1.0
410c6000 410c8000 r-xp /usr/lib/libXcomposite.so.1.0.0
410d0000 410d2000 r-xp /usr/lib/libXgesture.so.7.0.0
410db000 410de000 r-xp /usr/lib/libXfixes.so.3.1.0
410e6000 410e7000 r-xp /usr/lib/libXinerama.so.1.0.0
410f0000 410f6000 r-xp /usr/lib/libXrandr.so.2.2.0
410fe000 41104000 r-xp /usr/lib/libXrender.so.1.3.0
4110c000 41110000 r-xp /usr/lib/libXtst.so.6.1.0
41118000 41122000 r-xp /usr/lib/libXext.so.6.4.0
4112c000 41131000 r-xp /usr/lib/libecore_fb.so.1.7.99
4113a000 4113e000 r-xp /usr/lib/libecore_ipc.so.1.7.99
41147000 4114a000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
41152000 41168000 r-xp /lib/libexpat.so.1.6.0
41172000 41188000 r-xp /usr/lib/libtts.so
41192000 411b5000 r-xp /usr/lib/libui-extension.so.0.1.0
411be000 411c9000 r-xp /usr/lib/libtbm.so.1.0.0
411d1000 411d8000 r-xp /usr/lib/libembryo.so.1.7.99
411e0000 411f7000 r-xp /usr/lib/liblua-5.1.so
41200000 41201000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
4120a000 41218000 r-xp /usr/lib/libGLESv2.so.2.0
41221000 41239000 r-xp /usr/lib/libpng12.so.0.50.0
41241000 41242000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4124b000 41251000 r-xp /usr/lib/libxcb-render.so.0.0.0
41259000 4126c000 r-xp /usr/lib/libxcb.so.1.1.0
41275000 41278000 r-xp /usr/lib/libEGL.so.1.4
41281000 412a4000 r-xp /usr/lib/libjpeg.so.8.0.2
412bc000 41300000 r-xp /usr/lib/libcurl.so.4.3.0
41309000 4130b000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
41313000 4132b000 r-xp /usr/lib/liblzma.so.5.0.3
41334000 41336000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
4133f000 41341000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41349000 4134d000 r-xp /usr/lib/libsmack.so.1.0.0
41356000 41373000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
4137d000 41380000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41388000 41389000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41392000 4151a000 r-xp /usr/lib/libicui18n.so.57.1
4152a000 41630000 r-xp /usr/lib/libicuuc.so.57.1
41647000 4164f000 r-xp /usr/lib/libdrm.so.2.4.0
41657000 41659000 r-xp /usr/lib/libdri2.so.0.0.0
41661000 41663000 r-xp /usr/lib/libXau.so.6.0.0
4166b000 41674000 r-xp /usr/lib/libcares.so.2.1.0
4167d000 416ab000 r-xp /usr/lib/libidn.so.11.5.44
416b4000 416fb000 r-xp /usr/lib/libssl.so.1.0.0
41707000 41899000 r-xp /usr/lib/libcrypto.so.1.0.0
418ba000 418bc000 r-xp /usr/lib/libiri.so
418c4000 418c7000 r-xp /lib/libcap.so.2.21
418cf000 418d6000 r-xp /lib/libcrypt-2.13.so
41907000 4190d000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41915000 4191a000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41922000 4193b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
431dc000 431df000 r-xp /lib/libattr.so.1.1.0
431e8000 43209000 r-xp /usr/lib/libexif.so.12.3.3
4321c000 4321e000 r-xp /usr/lib/libttrace.so.1.1
43226000 4322b000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43233000 43239000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43242000 4324a000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43253000 43275000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4327e000 43285000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4328e000 43290000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43298000 4329f000 r-xp /usr/lib/libminizip.so.1.0.0
432a7000 432b4000 r-xp /usr/lib/libail.so.0.1.0
432be000 432c4000 r-xp /usr/lib/libproc-stat.so.0.2.96
432cc000 432cd000 r-xp /usr/lib/libresponse.so.0.2.96
432d5000 432da000 r-xp /usr/lib/libsystem.so.0.0.0
433ea000 434b4000 r-xp /usr/lib/libCOREGL.so.4.0
bef1c000 bef3d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5968)
Call Stack Count: 5
 0: fclose + 0x8 (0x404b4b58) [/lib/libc.so.6] + 0x5cb58
 1: Configuration::createConfigurationTextFile() + 0x3e (0x400063d3) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x63d3
 2: main + 0x32 (0x40003493) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x3493
 3: __libc_start_main + 0x114 (0x4046f85c) [/lib/libc.so.6] + 0x1785c
 4: (0x400032b8) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x32b8
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
__send_result_to_client(91) > __send_result_to_client, pid: 5953
06-18 20:34:17.792+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 12
06-18 20:34:17.872+0200 I/efl-extension( 5953): efl_extension.c: eext_mod_init(40) > Init
06-18 20:34:18.032+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 14
06-18 20:34:18.042+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-18 20:34:18.042+0200 W/CRASH_MANAGER( 5752): worker.c: worker_job(1205) > 110595373636f1497810857
06-18 20:34:18.042+0200 E/CAPI_APPFW_APP_MANAGER( 1312): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
06-18 20:34:18.042+0200 E/CAPI_APPFW_APP_MANAGER( 1312): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
06-18 20:34:18.072+0200 W/AUL     ( 5964): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.scorekeeperforgear]
06-18 20:34:18.077+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 23
06-18 20:34:18.077+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-18 20:34:18.077+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5953
06-18 20:34:18.077+0200 W/AUL_AMD (  504): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-18 20:34:18.077+0200 I/AUL_AMD (  504): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5953
06-18 20:34:18.077+0200 W/AUL     (  504): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5953)
06-18 20:34:18.117+0200 E/EFL     (  802): ecore_x<802> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1302358 button=1
06-18 20:34:18.117+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.117+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:34:18.122+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.127+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:18.137+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.137+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:18.142+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:34:18.142+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:34:18.142+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:34:18.157+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.157+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:18.167+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.167+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:18.192+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.192+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:18.202+0200 E/EFL     (  802): ecore_x<802> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1302446 button=1
06-18 20:34:18.202+0200 W/W_HOME  (  802): home_navigation.c: _up_cb(1247) > up
06-18 20:34:18.202+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:34:18.202+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-18 20:34:18.217+0200 W/AUL     (  962): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.scorekeeperforgear)
06-18 20:34:18.217+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 0
06-18 20:34:18.217+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1782) > caller pid : 962
06-18 20:34:18.217+0200 I/AUL_AMD (  504): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
06-18 20:34:18.232+0200 E/RESOURCED(  648): block.c: block_prelaunch_state(138) > insert data org.example.scorekeeperforgear, table num : 4
06-18 20:34:18.237+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2218) > pad pid(-5)
06-18 20:34:18.237+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(630) > Candidate is not prepared, enter legacy logic
06-18 20:34:18.237+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
06-18 20:34:18.237+0200 E/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(278) > launching failed
06-18 20:34:18.237+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2229) > Launch with legacy way : no launchpad
06-18 20:34:18.237+0200 W/AUL_AMD (  504): amd_launch.c: start_process(606) > child process: 5968
06-18 20:34:18.287+0200 W/AUL_AMD (  504): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5968
06-18 20:34:18.287+0200 W/AUL     (  504): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.scorekeeperforgear) pid(5968) type(uiapp) bg(2)
06-18 20:34:18.292+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-18 20:34:18.292+0200 W/AUL     (  962): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5968)
06-18 20:34:18.292+0200 E/APP_SHORTCUT_WIDGET(  962): main.c: _tts_button_mouse_clicked_cb(732) >  (tts_status == 0) -> _tts_button_mouse_clicked_cb() return
06-18 20:34:18.297+0200 W/STARTER (  769): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5968]
06-18 20:34:18.327+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 14
06-18 20:34:18.337+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5968
06-18 20:34:18.337+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 12
06-18 20:34:18.407+0200 E/EFL     (  802): ecore_x<802> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1302649 button=1
06-18 20:34:18.407+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.407+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:34:18.417+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.417+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:18.427+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.427+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:18.432+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:34:18.432+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:34:18.432+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:34:18.442+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.442+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:18.447+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.447+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:18.457+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.457+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:18.472+0200 I/efl-extension( 5968): efl_extension.c: eext_mod_init(40) > Init
06-18 20:34:18.472+0200 E/EFL     (  802): ecore_x<802> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1302715 button=1
06-18 20:34:18.472+0200 W/W_HOME  (  802): home_navigation.c: _up_cb(1247) > up
06-18 20:34:18.472+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:34:18.472+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-18 20:34:18.487+0200 W/AUL     (  962): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.scorekeeperforgear)
06-18 20:34:18.487+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 0
06-18 20:34:18.487+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1782) > caller pid : 962
06-18 20:34:18.487+0200 I/AUL_AMD (  504): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
06-18 20:34:18.497+0200 W/AUL     (  504): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(org.example.scorekeeperforgear) pid(5968) type(uiapp) bg(2)
06-18 20:34:18.497+0200 W/AUL_AMD (  504): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5968
06-18 20:34:18.497+0200 E/AUL     (  504): app_sock.c: __connect_client_sock(196) > connect error: 2
06-18 20:34:18.497+0200 E/AUL     (  504): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 2
06-18 20:34:18.497+0200 W/STARTER (  769): pkg-monitor.c: _app_mgr_status_cb(416) > [_app_mgr_status_cb:416] Resume request [5968]
06-18 20:34:18.597+0200 E/AUL     (  504): app_sock.c: __connect_client_sock(196) > connect error: 2
06-18 20:34:18.597+0200 E/AUL     (  504): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 2
06-18 20:34:18.647+0200 E/EFL     (  802): ecore_x<802> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1302889 button=1
06-18 20:34:18.647+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.647+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:34:18.667+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.667+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:18.677+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.677+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:18.682+0200 E/AUL     (  504): app_sock.c: __connect_client_sock(196) > connect error: 2
06-18 20:34:18.682+0200 E/AUL     (  504): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 2
06-18 20:34:18.682+0200 E/AUL_AMD (  504): amd_launch.c: _fake_launch_app(883) > error request fake launch - error code = -70
06-18 20:34:18.682+0200 E/AUL_AMD (  504): amd_launch.c: __nofork_processing(1247) > fake_launch failed. error code = -70
06-18 20:34:18.682+0200 W/AUL     (  962): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-3)
06-18 20:34:18.682+0200 E/CAPI_APPFW_APP_CONTROL(  962): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-18 20:34:18.682+0200 E/APP_SHORTCUT_WIDGET(  962): main.c: _slot_mouse_clicked_cb(713) > error
06-18 20:34:18.682+0200 E/APP_SHORTCUT_WIDGET(  962): main.c: _tts_button_mouse_clicked_cb(732) >  (tts_status == 0) -> _tts_button_mouse_clicked_cb() return
06-18 20:34:18.687+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-18 20:34:18.687+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2280) > back key ungrab error
06-18 20:34:18.687+0200 E/AUL_AMD (  504): amd_launch.c: __real_send(909) > send fail to client
06-18 20:34:18.687+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 14
06-18 20:34:18.692+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-18 20:34:18.692+0200 E/CAPI_APPFW_APP_MANAGER( 1312): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
06-18 20:34:18.692+0200 E/CAPI_APPFW_APP_MANAGER( 1312): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
06-18 20:34:18.692+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-18 20:34:18.697+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.697+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:18.702+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:34:18.702+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:34:18.702+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:34:18.707+0200 E/EFL     (  802): ecore_x<802> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1302943 button=1
06-18 20:34:18.707+0200 W/W_HOME  (  802): home_navigation.c: _up_cb(1247) > up
06-18 20:34:18.707+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:34:18.707+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-18 20:34:18.712+0200 W/AUL     ( 5976): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.scorekeeperforgear]
06-18 20:34:18.712+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 23
06-18 20:34:18.712+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-18 20:34:18.712+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5968
06-18 20:34:18.712+0200 W/AUL_AMD (  504): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-18 20:34:18.717+0200 I/AUL_AMD (  504): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5968
06-18 20:34:18.717+0200 W/AUL     (  504): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5968)
06-18 20:34:18.727+0200 W/AUL     (  962): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.scorekeeperforgear)
06-18 20:34:18.732+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 0
06-18 20:34:18.732+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1782) > caller pid : 962
06-18 20:34:18.732+0200 I/AUL_AMD (  504): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
06-18 20:34:18.742+0200 E/RESOURCED(  648): block.c: block_prelaunch_state(138) > insert data org.example.scorekeeperforgear, table num : 4
06-18 20:34:18.747+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2218) > pad pid(-5)
06-18 20:34:18.747+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(630) > Candidate is not prepared, enter legacy logic
06-18 20:34:18.747+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
06-18 20:34:18.747+0200 E/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(278) > launching failed
06-18 20:34:18.747+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2229) > Launch with legacy way : no launchpad
06-18 20:34:18.747+0200 W/AUL_AMD (  504): amd_launch.c: start_process(606) > child process: 5977
06-18 20:34:18.797+0200 W/AUL_AMD (  504): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5977
06-18 20:34:18.797+0200 W/AUL     (  504): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.scorekeeperforgear) pid(5977) type(uiapp) bg(2)
06-18 20:34:18.802+0200 W/AUL     (  962): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5977)
06-18 20:34:18.802+0200 E/APP_SHORTCUT_WIDGET(  962): main.c: _tts_button_mouse_clicked_cb(732) >  (tts_status == 0) -> _tts_button_mouse_clicked_cb() return
06-18 20:34:18.802+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-18 20:34:18.802+0200 W/AUL_AMD (  504): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
06-18 20:34:18.802+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-18 20:34:18.812+0200 W/STARTER (  769): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5977]
06-18 20:34:18.852+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 14
06-18 20:34:18.857+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5977
06-18 20:34:18.862+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 12
06-18 20:34:18.882+0200 E/EFL     (  802): ecore_x<802> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1303126 button=1
06-18 20:34:18.882+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.882+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:34:18.892+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.892+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:18.902+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 14
06-18 20:34:18.902+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.902+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:18.907+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:34:18.907+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5977
06-18 20:34:18.907+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:34:18.907+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:34:18.922+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 12
06-18 20:34:18.927+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.927+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:18.937+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:18.937+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:18.947+0200 E/EFL     (  802): ecore_x<802> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1303192 button=1
06-18 20:34:18.947+0200 W/W_HOME  (  802): home_navigation.c: _up_cb(1247) > up
06-18 20:34:18.947+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:34:18.947+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-18 20:34:18.962+0200 W/AUL     (  962): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.scorekeeperforgear)
06-18 20:34:18.962+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 0
06-18 20:34:18.967+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1782) > caller pid : 962
06-18 20:34:18.967+0200 I/AUL_AMD (  504): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
06-18 20:34:18.972+0200 W/AUL     (  504): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(org.example.scorekeeperforgear) pid(5977) type(uiapp) bg(2)
06-18 20:34:18.972+0200 W/AUL_AMD (  504): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5977
06-18 20:34:18.972+0200 E/AUL     (  504): app_sock.c: __connect_client_sock(196) > connect error: 2
06-18 20:34:18.972+0200 E/AUL     (  504): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 2
06-18 20:34:18.977+0200 W/STARTER (  769): pkg-monitor.c: _app_mgr_status_cb(416) > [_app_mgr_status_cb:416] Resume request [5977]
06-18 20:34:19.017+0200 I/efl-extension( 5977): efl_extension.c: eext_mod_init(40) > Init
06-18 20:34:19.072+0200 E/AUL     (  504): app_sock.c: __connect_client_sock(196) > connect error: 2
06-18 20:34:19.072+0200 E/AUL     (  504): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 2
06-18 20:34:19.127+0200 E/EFL     (  802): ecore_x<802> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1303372 button=1
06-18 20:34:19.127+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:19.132+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:34:19.137+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:19.137+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:19.147+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:19.147+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:19.162+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:19.162+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:19.172+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-18 20:34:19.172+0200 E/EFL     (  802): elementary<802> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-18 20:34:19.182+0200 E/EFL     (  802): ecore_x<802> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1303427 button=1
06-18 20:34:19.182+0200 W/W_HOME  (  802): home_navigation.c: _up_cb(1247) > up
06-18 20:34:19.182+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-18 20:34:19.182+0200 W/W_HOME  (  802): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-18 20:34:19.332+0200 E/AUL     (  504): app_sock.c: __connect_client_sock(196) > connect error: 2
06-18 20:34:19.332+0200 E/AUL     (  504): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 2
06-18 20:34:19.332+0200 E/AUL_AMD (  504): amd_launch.c: _fake_launch_app(883) > error request fake launch - error code = -70
06-18 20:34:19.332+0200 E/AUL_AMD (  504): amd_launch.c: __nofork_processing(1247) > fake_launch failed. error code = -70
06-18 20:34:19.332+0200 W/AUL     (  962): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-3)
06-18 20:34:19.332+0200 E/CAPI_APPFW_APP_CONTROL(  962): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-18 20:34:19.332+0200 E/APP_SHORTCUT_WIDGET(  962): main.c: _slot_mouse_clicked_cb(713) > error
06-18 20:34:19.332+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-18 20:34:19.332+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2280) > back key ungrab error
06-18 20:34:19.332+0200 E/AUL_AMD (  504): amd_launch.c: __real_send(909) > send fail to client
06-18 20:34:19.332+0200 E/APP_SHORTCUT_WIDGET(  962): main.c: _tts_button_mouse_clicked_cb(732) >  (tts_status == 0) -> _tts_button_mouse_clicked_cb() return
06-18 20:34:19.337+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:34:19.337+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:34:19.337+0200 E/EFL     (  962): evas_main<962> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
06-18 20:34:19.347+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-18 20:34:19.347+0200 W/AUL_AMD (  504): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
06-18 20:34:19.347+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-18 20:34:19.352+0200 W/AUL     (  962): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.scorekeeperforgear)
06-18 20:34:19.357+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 0
06-18 20:34:19.357+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1782) > caller pid : 962
06-18 20:34:19.357+0200 I/AUL_AMD (  504): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
06-18 20:34:19.367+0200 E/RESOURCED(  648): block.c: block_prelaunch_state(138) > insert data org.example.scorekeeperforgear, table num : 4
06-18 20:34:19.372+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2218) > pad pid(-5)
06-18 20:34:19.372+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(630) > Candidate is not prepared, enter legacy logic
06-18 20:34:19.372+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
06-18 20:34:19.372+0200 E/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(278) > launching failed
06-18 20:34:19.372+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2229) > Launch with legacy way : no launchpad
06-18 20:34:19.372+0200 W/AUL_AMD (  504): amd_launch.c: start_process(606) > child process: 5983
06-18 20:34:19.422+0200 I/AUL_PAD ( 5930): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
06-18 20:34:19.427+0200 W/AUL_AMD (  504): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5983
06-18 20:34:19.427+0200 W/AUL     (  504): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.scorekeeperforgear) pid(5983) type(uiapp) bg(2)
06-18 20:34:19.427+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-18 20:34:19.427+0200 W/AUL     (  962): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5983)
06-18 20:34:19.427+0200 E/APP_SHORTCUT_WIDGET(  962): main.c: _tts_button_mouse_clicked_cb(732) >  (tts_status == 0) -> _tts_button_mouse_clicked_cb() return
06-18 20:34:19.432+0200 W/STARTER (  769): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5983]
06-18 20:34:19.472+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 14
06-18 20:34:19.477+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5983
06-18 20:34:19.477+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 12
06-18 20:34:19.507+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 14
06-18 20:34:19.512+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5983
06-18 20:34:19.512+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 12
06-18 20:34:19.622+0200 I/efl-extension( 5983): efl_extension.c: eext_mod_init(40) > Init
06-18 20:34:19.682+0200 W/W_HOME  (  802): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
06-18 20:34:19.802+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-18 20:34:19.802+0200 W/AUL_AMD (  504): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
06-18 20:34:19.967+0200 W/AUL     ( 5989): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.scorekeeperforgear]
06-18 20:34:19.967+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 23
06-18 20:34:19.972+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-18 20:34:19.972+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5977
06-18 20:34:19.972+0200 W/AUL_AMD (  504): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-18 20:34:19.972+0200 I/AUL_AMD (  504): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5977
06-18 20:34:19.972+0200 W/AUL     (  504): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5977)
06-18 20:34:20.222+0200 W/WATCH_CORE(  937): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
06-18 20:34:20.222+0200 I/WATCH_CORE(  937): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
06-18 20:34:20.222+0200 I/CAPI_WATCH_APPLICATION(  937): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-18 20:34:20.222+0200 E/watchface-app(  937): watchface.cpp: OnAppTimeTick(744) > 
06-18 20:34:20.222+0200 I/watchface-app(  937): watchface.cpp: OnAppTimeTick(756) > set force update!!
06-18 20:34:20.222+0200 I/watchface-viewer(  937): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
06-18 20:34:20.222+0200 I/watchface-viewer(  937): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 275x63
06-18 20:34:20.237+0200 I/watchface-viewer(  937): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(577) > ImagesLoadingDoneSignal().Emit()
06-18 20:34:20.297+0200 W/WATCH_CORE(  937): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
06-18 20:34:20.297+0200 W/W_HOME  (  802): dbus.c: _dbus_message_recv_cb(204) > LCD off
06-18 20:34:20.297+0200 W/W_HOME  (  802): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
06-18 20:34:20.297+0200 W/W_HOME  (  802): gesture.c: _manual_render_disable_timer_del(157) > timer del
06-18 20:34:20.297+0200 W/W_HOME  (  802): gesture.c: _manual_render_enable(138) > 1
06-18 20:34:20.297+0200 W/W_HOME  (  802): event_manager.c: _lcd_off_cb(729) > lcd state: 0
06-18 20:34:20.297+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:34:20.302+0200 W/STARTER (  769): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [gesture]
06-18 20:34:20.302+0200 W/STARTER (  769): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
06-18 20:34:20.302+0200 E/STARTER (  769): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
06-18 20:34:20.302+0200 W/STARTER (  769): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
06-18 20:34:20.302+0200 W/STARTER (  769): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
06-18 20:34:20.312+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : 1075006220[0;m
06-18 20:34:20.322+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
06-18 20:34:20.322+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
06-18 20:34:20.322+0200 E/WAKEUP-SERVICE( 1378): WakeupService.cpp: _WakeupIsAvailable(327) > [0;31mERROR: db/knoxcustom/prokiosk_state_enable FAILED[0;m
06-18 20:34:20.342+0200 I/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
06-18 20:34:20.347+0200 I/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
06-18 20:34:20.347+0200 W/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
06-18 20:34:20.352+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
06-18 20:34:20.352+0200 I/HIGEAR  ( 1378): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
06-18 20:34:20.422+0200 W/SHealthCommon( 1009): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:3[0;m
06-18 20:34:20.422+0200 I/watchface-viewer(  937): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
06-18 20:34:20.422+0200 I/w-magazine-widget(  979): widget.c: _magazine_widget_display_status_cb(493) > LCD off
06-18 20:34:20.427+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-18 20:34:20.427+0200 W/AUL_AMD (  504): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
06-18 20:34:20.437+0200 W/STARTER (  769): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [gesture]
06-18 20:34:20.437+0200 W/STARTER (  769): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
06-18 20:34:20.437+0200 W/STARTER (  769): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
06-18 20:34:20.437+0200 W/STARTER (  769): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[0]
06-18 20:34:20.437+0200 E/ALARM_MANAGER(  769): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(18-6-2017, 20:34:40), repeat(1), interval(20), type(-1073741822)
06-18 20:34:20.442+0200 I/APP_CORE(  802): appcore-efl.c: __do_app(453) > [APP 802] Event: PAUSE State: RUNNING
06-18 20:34:20.442+0200 I/CAPI_APPFW_APPLICATION(  802): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-18 20:34:20.442+0200 W/W_HOME  (  802): main.c: _appcore_pause_cb(487) > appcore pause
06-18 20:34:20.442+0200 W/W_HOME  (  802): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
06-18 20:34:20.442+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:34:20.442+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:34:20.442+0200 W/W_HOME  (  802): main.c: home_pause(546) > clock/widget paused
06-18 20:34:20.442+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:34:20.442+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:34:20.442+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:34:20.442+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:34:20.442+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-18 20:34:20.442+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-18 20:34:20.442+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:34:20.442+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-18 20:34:20.442+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:34:20.447+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:34:20.447+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:34:20.447+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:34:20.447+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-18 20:34:20.447+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-18 20:34:20.447+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:34:20.447+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-18 20:34:20.447+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-18 20:34:20.447+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-18 20:34:20.447+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:34:20.447+0200 E/CAPI_APPFW_APP_CONTROL( 1110): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-18 20:34:20.447+0200 W/MUSIC_CONTROL_SERVICE( 1110): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1110]   [com.samsung.w-home]register msg port [false][0m
06-18 20:34:20.467+0200 E/APP_SHORTCUT_WIDGET(  962): main.c: widget_instance_pause(1669) >  (!popup) -> widget_instance_pause() return
06-18 20:34:20.467+0200 I/CAPI_WIDGET_APPLICATION(  962): widget_app.c: __provider_pause_cb(298) > widget obj was paused
06-18 20:34:20.467+0200 W/AUL     (  962): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.app-widget.widget) pid(962) status(bg) type(widgetapp)
06-18 20:34:20.472+0200 I/CAPI_WIDGET_APPLICATION(  962): widget_app.c: __check_status_for_cgroup(145) > enter background group
06-18 20:34:20.477+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [769].
06-18 20:34:20.502+0200 W/SHealthCommon( 1312): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:3[0;m
06-18 20:34:20.502+0200 W/W_INDICATOR(  796): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
06-18 20:34:20.512+0200 E/ALARM_MANAGER(  509): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 992089869, next duetime: 1497810880
06-18 20:34:20.512+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(992089869)
06-18 20:34:20.512+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1497818871), due_time(1497810880)
06-18 20:34:20.522+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
06-18 20:34:20.527+0200 W/SHealthService( 1312): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
06-18 20:34:20.527+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-18 20:34:20.527+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 18-6-2017, 18:34:40 (UTC).
06-18 20:34:20.527+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-18 20:34:20.527+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __save_module_log(1778) > The file is not ready.
06-18 20:34:20.537+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
06-18 20:34:20.537+0200 E/ALARM_MANAGER(  509): alarm-manager.c: __save_module_log(1778) > The file is not ready.
06-18 20:34:20.542+0200 W/W_INDICATOR(  796): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
06-18 20:34:20.542+0200 W/W_INDICATOR(  796): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-18 20:34:20.642+0200 W/W_INDICATOR(  796): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
06-18 20:34:20.642+0200 W/W_INDICATOR(  796): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
06-18 20:34:20.642+0200 W/W_INDICATOR(  796): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
06-18 20:34:20.952+0200 I/APP_CORE(  802): appcore-efl.c: __do_app(453) > [APP 802] Event: MEM_FLUSH State: PAUSED
06-18 20:34:25.452+0200 I/APP_CORE(  802): appcore-efl.c: __do_app(453) > [APP 802] Event: MEM_FLUSH State: PAUSED
06-18 20:34:27.587+0200 W/SHealthWidget( 1009): HeartRateWidgetViewController.cpp: OnTimerTick(164) > [1;35m BEGIN >>>>[0;m
06-18 20:34:27.587+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-18 20:34:27.587+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-18 20:34:27.587+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-18 20:34:27.587+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-18 20:34:27.587+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-18 20:34:27.587+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-18 20:34:27.587+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-18 20:34:27.587+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-18 20:34:27.587+0200 W/SHealthAppCommon( 1009): HeartRateLayout.cpp: UpdateTime(98) > [1;35mtimeString:[Il y a 15 h][0;m
06-18 20:34:27.587+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-18 20:34:27.587+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-18 20:34:27.587+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-18 20:34:27.587+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-18 20:34:27.587+0200 W/SHealthAppCommon( 1009): HeartRateLayout.cpp: SetEDCStateByCurrentHRValueType(264) > [1;35mhide_title_show_main_sub_text[0;m
06-18 20:34:27.587+0200 W/SHealthAppCommon( 1009): HeartRateLayout.cpp: CreateHeartRateSubTimeString(115) > [1;35mdurationMin:993, diffSec:59637[0;m
06-18 20:34:27.587+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-18 20:34:27.587+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-18 20:34:27.587+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-18 20:34:27.587+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-18 20:34:27.592+0200 W/SHealthAppCommon( 1009): HeartRateLayout.cpp: UpdateTagIcon(194) > [1;35mtag_icon_visible[0;m
06-18 20:34:27.592+0200 W/SHealthWidget( 1009): HeartRateWidgetViewController.cpp: OnTimerTick(177) > [1;35m END <<<<[0;m
06-18 20:34:30.852+0200 W/CRASH_MANAGER( 5752): worker.c: worker_job(1205) > 110596873636f149781085
