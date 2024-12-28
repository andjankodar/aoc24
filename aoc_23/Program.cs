﻿using System.Collections.Generic;
using System.Text.RegularExpressions;

var testInput = """
    kh-tc
    qp-kh
    de-cg
    ka-co
    yn-aq
    qp-ub
    cg-tb
    vc-aq
    tb-ka
    wh-tc
    yn-cg
    kh-ub
    ta-co
    de-co
    tc-td
    tb-wq
    wh-td
    ta-ka
    td-qp
    aq-cg
    wq-ub
    ub-vc
    de-ta
    wq-aq
    wq-vc
    wh-yn
    ka-de
    kh-ta
    co-tc
    wh-qp
    tb-vc
    td-yn
    """;

var input = """
xg-ed
ck-hh
on-wa
nn-pf
iv-rr
vv-xo
mw-qf
ex-ii
qx-xj
ql-tb
gh-bs
hy-yi
qj-zs
lz-zn
kt-mj
dq-xa
vw-zd
jx-ts
xz-fo
ij-mg
rb-co
lb-qh
ac-bp
ni-ce
la-yp
mk-ui
lz-ox
oe-rv
ab-xf
ux-do
aa-vo
ta-ax
nm-kn
dw-vf
kl-ze
wu-vl
jc-jm
im-yx
jp-dd
td-oc
cx-wy
aj-il
do-qx
jm-yr
da-af
sj-fm
xa-pb
ed-mk
xw-xt
pv-wl
ny-lf
id-er
tp-zq
cx-cj
hc-lu
ij-hi
qa-ox
oq-jz
ad-yc
bh-me
ro-ky
pf-lz
ya-wi
al-el
yp-zm
fe-ng
kj-gp
qx-dj
so-fo
or-tj
dt-pe
vz-pq
ty-kr
hx-ab
mi-ly
al-tm
ml-xh
rz-di
lw-em
tm-bu
fr-rn
bb-mt
ke-oe
my-jk
my-rd
qw-kz
kr-xm
ij-nw
lo-zo
lp-es
tg-fo
nf-ku
hx-kh
pd-vm
al-ja
jf-qg
qo-hj
qb-na
ny-pb
aw-ry
dp-uf
kq-rm
ki-pv
ie-ub
yd-pu
ab-ku
gg-mw
bs-ke
fo-un
pq-bp
fr-jj
vd-ce
kg-pq
yb-kq
bv-cg
sa-ta
qb-yt
eo-uh
oz-kr
nq-fd
yk-gp
jf-gc
es-in
fh-zs
bp-zb
dt-yr
zn-zk
ld-lb
uk-pm
yi-ws
ly-hi
nr-hf
lo-bz
qx-jd
fj-ui
ob-lt
az-fx
yn-yz
ck-ip
kf-if
jm-ta
fv-yz
ts-xb
od-kk
zs-de
tt-ry
uf-kr
cl-cj
wd-uh
tw-ab
ln-dw
oe-mz
qx-fu
gs-ju
pj-so
im-ka
ki-wl
sc-pa
cf-gw
wt-rb
kr-kt
op-ic
gf-dc
pn-gs
mg-aq
ii-on
kh-ws
nl-zv
td-rc
od-yp
rd-ed
kk-yr
ok-mu
tv-cl
lk-vl
bv-zn
ob-ml
at-yy
vu-km
pb-oh
do-zq
zs-ma
dd-rz
ef-tu
ha-mq
te-ev
ps-nf
me-zv
we-rs
ty-va
gg-ki
nk-id
ip-rs
po-kt
mt-ss
ry-cy
mg-ly
wq-tx
rl-bb
wa-gb
ih-ii
bn-eo
zo-zt
gb-vc
vy-bf
pn-hp
zs-ey
bh-eu
ny-dm
me-lr
fd-ek
ev-qt
my-dd
xd-wc
mu-sj
ia-hj
rd-te
ce-lj
lc-ym
ww-vg
aa-ln
qu-gt
oj-pz
xd-kk
fa-ky
nr-cg
ot-dd
wh-ut
zg-fa
co-yp
tm-wo
kz-yt
gp-xe
tb-hh
cs-sh
ck-hw
ql-tg
ym-cy
iu-mb
fa-vz
bf-lp
vm-un
dm-jn
dp-el
zs-fi
rr-yb
ky-bk
tj-rq
io-zs
is-or
bl-lw
tl-cy
ff-he
as-gp
kf-ut
gy-uu
va-uf
rz-wo
ib-dy
tc-uh
iv-rm
ou-dk
gb-yf
xi-si
kw-nr
we-hh
ma-qj
tz-pl
cq-yb
ds-yy
xj-zq
ab-gc
rn-vh
yl-ik
nt-gy
mr-jh
ci-ej
wo-bw
ai-jj
ym-yv
tw-qg
as-ax
og-ei
cc-wh
ge-id
mc-ir
nh-yo
cl-lq
fk-ef
mb-se
rr-sv
uk-pi
te-fj
at-gb
sc-tw
ke-ba
zk-iy
sl-ps
tu-uh
ao-hk
iq-km
wo-ot
er-iw
ss-bb
fx-wb
ex-tl
pp-wc
gh-qi
lm-vx
gq-zo
hl-vh
jl-ef
rz-jk
bu-qu
bx-ab
ub-xa
qg-sc
uh-fk
yw-lr
bx-xf
zm-lq
ml-nv
wu-pb
eu-tx
fd-gy
vw-cd
ad-iy
np-nm
gz-ao
iq-ac
lc-bu
ml-td
sk-cc
eo-cv
pz-jh
im-hr
sv-rm
tj-bl
sa-xe
qk-tz
dd-jk
ou-yp
ob-td
ic-dl
ez-iq
rf-ib
rd-xg
oj-jh
nl-ws
na-qw
zi-zs
dv-ib
ls-yl
rb-od
jb-tu
ix-zl
qp-pz
hw-kd
kg-vu
xl-ws
qo-wh
xt-jf
gf-de
lf-iw
bh-jz
lx-wl
wq-zv
lq-gs
jj-rv
xc-yl
rc-nv
iu-zo
my-av
gt-bu
ya-lp
ps-fa
pz-vh
xf-sc
fr-ec
ax-ce
zq-np
va-ng
hk-vx
vz-zb
yt-ei
xl-sg
cw-nh
yp-he
mb-zt
vz-ac
ny-az
qb-kz
si-gh
zh-wi
lm-qi
rm-dy
bo-ed
rn-ai
ax-lj
xb-tn
vc-am
qw-lw
fz-ln
tu-sx
xz-fp
yf-on
bj-ys
sa-no
zl-ez
pp-nb
kl-bl
ln-la
bk-mq
gh-ba
sd-ij
gv-th
mk-sf
fu-np
la-rb
tl-rw
so-pd
cm-jq
ho-rw
zd-lt
fm-cg
kl-th
iw-ge
ze-bl
bu-pm
xa-oh
oz-ng
ev-xg
cw-yo
fv-jm
eb-vx
mz-ba
vd-sa
bb-fd
ny-bc
wa-am
oc-lt
ni-kj
ky-fh
zg-ps
po-uf
kl-og
ln-za
yk-cl
ly-of
uj-ts
er-az
et-sv
zr-bu
my-rz
ur-te
ja-tm
qu-cf
wb-nk
hi-of
ex-at
md-yp
in-ak
hw-ju
gr-wl
kw-cg
rc-zd
fr-rv
nl-da
hp-yk
xc-db
bx-ku
gp-lj
vx-cu
gr-pv
ic-js
rc-jy
jw-fa
ze-th
dx-js
ui-ur
eo-ki
qx-ag
gz-hk
ys-ky
in-mo
pa-tj
bd-pw
yt-og
il-ls
ww-jn
bz-jn
wz-bc
ed-ev
rf-cu
uv-cc
wy-lq
sv-ib
aq-sd
od-qs
ho-ym
pe-js
og-em
ob-xh
cq-sv
pi-li
rd-qt
ka-lm
er-zc
ja-qu
tw-gc
wa-jb
co-uv
cj-tv
ex-on
te-kn
al-cf
ii-vc
xh-oc
pb-to
is-dj
dm-iw
fv-pp
nf-tw
jx-ow
bs-mc
wm-sf
yp-rb
eo-tu
dq-pb
qy-nr
vd-ta
rm-rr
tn-ve
ki-jq
cf-pm
am-on
yj-cv
si-gl
lf-bc
ju-rs
kj-ce
io-fi
hw-wm
gf-ey
ie-lk
ac-pq
ka-cs
xd-jm
lo-iu
pi-iv
ee-pj
gh-ke
xi-gl
md-ff
dp-va
ho-yh
af-ws
gi-bp
uv-if
qh-ic
uv-dz
bj-ha
zl-bp
pd-pj
eq-hy
gy-wt
sl-bk
yr-wc
ik-xc
eo-jb
oc-jy
rb-ou
sh-yx
xf-kh
yf-vc
ec-il
it-qo
ai-oj
vh-oj
pe-dl
sx-yj
xo-dn
iw-az
ps-jw
ew-qs
jx-xb
oe-gh
is-ow
is-ts
us-tu
mq-ps
gz-lm
jn-an
uk-qu
nw-kw
wb-zc
og-kz
qo-uv
ce-fw
wm-hh
ak-xo
ro-fa
bh-du
gg-gr
gq-se
gb-dv
as-fw
rl-nt
zh-ya
hk-cu
gv-aq
fh-fi
wy-hp
jq-pv
wt-uu
jp-ot
ot-bw
dj-hq
cd-ss
iv-kq
ao-lm
bu-sr
vc-by
tk-sd
qp-rv
zj-mw
mj-gb
cm-mw
tm-uk
in-zh
pq-zb
lz-fc
ko-dd
ex-am
dz-wh
he-la
jf-tw
wi-mo
tz-eq
qa-zk
dt-qh
md-he
db-bd
bd-ik
ox-fc
em-kz
fp-so
qy-nh
xj-kn
yv-wg
fj-pu
ub-oh
ef-bn
zo-bz
gi-ni
sv-pi
hl-vb
cm-ki
nw-tk
xw-et
gi-ej
ia-ln
ux-fa
ep-ez
lp-wu
nr-cw
tb-vm
hx-nf
vy-xo
bw-di
ar-ia
iv-sv
oy-po
zo-se
mo-ya
lo-mp
sf-vt
my-dh
jq-gr
bw-jk
ev-fj
cx-tf
er-dm
ts-um
xa-to
hp-cj
rc-vw
fw-ax
fw-kj
oq-du
xj-dj
qk-qf
io-de
wk-cg
qa-fc
dn-vy
bs-si
rl-ek
ni-fw
ux-jw
yr-fv
ce-no
ck-tr
tj-uj
bh-ix
iw-wd
oj-qp
tu-ek
es-mo
ym-wg
in-ya
cb-xc
gf-qj
lq-tf
nv-vw
bh-oq
ap-nw
zd-ml
if-cc
on-gb
zt-lo
qd-ip
ps-gt
dv-mj
zg-ky
ux-zg
im-cs
gz-iy
sx-uh
ny-er
eu-wq
pe-xw
mi-nw
fi-zi
vt-gc
fp-vm
hq-xj
dn-ak
op-lb
fy-xz
pj-tg
ep-zl
kr-po
yx-hk
fx-iw
ty-fe
tn-uj
kl-ei
pc-rc
aq-nz
ni-lj
tw-kh
lf-wb
bp-vz
kd-tr
tg-so
ex-yf
qb-qw
op-xw
if-it
ls-ah
pj-un
un-tb
yh-tl
wh-kf
ze-qw
hq-zq
ld-ic
dt-ld
if-ea
ce-sa
yk-lq
ic-gr
ik-cb
yo-hf
ey-fi
ew-he
gz-ka
tp-zs
gg-qf
jh-jj
cj-fq
ba-xi
dq-vl
hu-ub
gi-iq
sy-nq
tg-ee
al-pm
hp-tv
cq-kq
ag-jd
ji-sy
zq-jd
wz-ts
qp-kz
ne-tx
qf-lx
wg-yh
bl-kz
hy-af
vw-xp
wq-ne
wz-or
fz-za
jl-jx
bn-bf
ot-jk
an-vg
ox-yc
zb-ac
vb-jj
fo-ql
na-em
cb-il
kh-bx
nn-qa
er-nk
gp-no
jx-wz
wz-rq
fv-jc
iq-av
bk-ro
sy-vo
tw-zq
si-ke
ha-ro
tk-cv
pe-ic
sd-zi
lw-ei
kn-jd
ar-sy
dc-zs
pq-zl
ov-gh
ri-mc
ee-un
lq-hp
lt-td
fc-er
ne-oq
me-du
nb-jc
nm-do
um-is
ls-bd
ff-qs
qk-af
wi-xo
pl-ll
rc-ml
ia-kr
ap-hi
li-kq
fh-de
ot-zx
uf-oy
fm-cw
qb-cs
zl-aa
wc-fv
mj-ex
mu-qy
zd-nv
yv-yh
fi-wk
tc-nh
zj-qf
ei-em
xj-np
ju-kd
od-la
ly-gv
jw-ha
fc-ad
an-mb
ib-iv
rs-kd
fe-kr
sx-us
sr-cf
dd-wo
sf-rs
ce-as
ny-nk
kw-cw
ig-ku
xm-po
pj-xz
jf-ab
us-cv
ep-kg
kw-sj
bb-wt
to-oh
va-oy
jh-qp
jm-wc
de-vj
ih-wa
yk-tv
vc-at
ix-tx
mo-ak
wu-oh
hf-nh
tv-gs
bd-yl
nn-ad
ep-gi
gv-ij
pf-qa
aw-ym
ry-ym
eo-sx
ji-jr
th-og
dp-fe
yo-fm
rm-yj
lj-no
og-qw
km-ep
ou-od
hy-pl
gq-ou
uu-bb
uj-ow
cb-ec
co-zm
ww-gq
oz-oy
hq-qx
ib-kq
wi-lp
kf-qo
fv-nb
cl-pn
dz-ug
er-bc
nm-dj
yy-ad
xa-qa
aq-hi
js-xt
ug-cc
yc-nn
ei-lt
gt-gw
gg-lx
ie-hu
em-bl
rv-rn
ml-jy
fk-jb
ur-xg
rs-ez
vu-ac
ah-db
cx-yk
hh-hw
em-gh
fx-ny
ps-bj
qi-ke
my-zx
sr-al
ig-jf
ki-ok
lt-rc
io-dc
co-od
kr-ng
cx-hp
ce-pd
wk-fh
ed-te
dy-li
rv-hl
wt-nt
gw-sr
xt-op
tt-wg
ry-lc
nt-ci
nk-zc
bp-iq
rs-tr
zr-al
lc-yv
op-js
tm-pm
bb-gy
sd-of
rm-rf
fq-hp
no-sj
bz-ww
gf-zs
af-nl
la-qs
eq-nl
ut-it
mz-ov
an-bz
gg-pv
uu-ej
by-ih
jx-pa
uv-kf
xi-ov
pz-mr
rr-li
po-va
rw-wg
wc-jc
yy-qa
jd-fu
rl-mt
ls-cb
ui-xg
cq-li
zh-lp
ls-ql
ke-mc
km-zb
cd-ek
bn-cv
ax-ni
lm-cs
cf-ja
ig-tw
qa-zn
kj-ta
zr-gb
pe-dx
he-qs
kd-ip
ea-ep
ut-uv
yf-by
vd-ni
np-hq
qp-vh
ta-xe
zi-io
az-wb
pj-fy
nb-pn
oe-bs
wu-ie
vf-ar
wm-qd
jn-vg
lz-yc
nm-hq
rm-ib
vg-mp
fz-td
ih-yf
cg-tc
vz-km
vt-hh
cy-rw
ya-cg
cm-vp
eb-sh
fj-qt
yt-lw
rr-rf
qk-ws
lj-yw
ho-aw
gw-tm
nz-sd
ow-wz
xm-ir
dp-xm
km-pq
vv-bf
tj-ts
us-ef
bx-jf
se-an
uv-ug
dn-zh
mr-jj
xe-ni
ot-ko
di-jp
az-zc
ay-yl
ut-if
nz-gv
yh-rw
bj-sl
og-na
iw-id
oh-ve
ze-yh
bs-xi
lt-nv
ir-po
sv-rf
la-md
nk-fx
xg-pu
xd-yr
ui-yd
zc-ge
vb-sa
vu-ez
yn-fv
ix-wq
ci-wt
xh-td
id-lf
ro-jw
vj-ke
gt-pm
ut-dz
eu-uu
fr-or
gy-rl
ci-uu
dy-yb
yz-hw
or-rq
la-dk
gb-am
yo-qy
ka-sh
yy-pf
zo-vg
qh-af
mb-lo
zm-la
xl-ja
tp-hq
oc-rc
gb-by
pl-nl
kg-tg
rr-et
dp-ng
to-ve
of-ij
oj-rn
ug-ut
cy-lc
he-rb
wy-yk
gw-ja
ys-ha
im-vx
vo-vf
jw-sl
na-lw
dw-sy
pi-dy
dn-mo
oj-fr
rn-pz
al-sx
pm-el
jj-hl
rz-av
dd-if
dj-fu
hc-rz
yo-sj
lq-pn
aa-sy
vu-ep
ck-vt
nn-lz
dk-he
uk-zr
gf-fi
nk-wi
nr-yo
wg-je
tf-cl
za-aa
hw-vt
as-ni
qu-gw
hp-tf
ry-pe
je-cy
et-kq
cc-jc
ll-tz
qd-ju
gv-of
lf-aj
pw-ah
ee-tb
nn-zk
od-md
xl-yi
oc-xp
nh-sj
pq-jy
lz-ds
et-rf
hj-wh
mb-jn
aj-ls
vl-pb
nt-mt
dm-fx
il-db
cg-qy
jr-aa
cs-gz
my-ot
sk-ea
hr-gz
in-wi
xl-nl
xz-un
ji-oq
gi-km
ri-mz
bc-fx
ot-rz
pi-rm
wt-cd
zt-jn
uk-bu
eb-cu
ek-ss
vj-gf
eb-ka
kl-kz
zt-iu
tl-ry
pa-uj
kl-em
sh-lm
nw-hi
th-bl
hi-nz
hr-ka
vz-gi
zm-od
za-ar
qf-wl
ad-pf
eq-yi
sl-fa
we-hw
im-ao
fj-ur
pm-ja
fc-yy
bs-sg
zl-zb
va-kr
de-dc
ai-qp
he-ui
mi-of
km-bp
tv-tf
dw-za
dx-gj
dt-dl
kf-ug
ov-ke
nv-td
od-he
sk-if
ux-sl
cg-cw
pz-ai
xb-rq
jy-xp
yx-ao
ui-ml
gr-mw
co-ew
zt-bz
rq-pa
ce-jr
hj-ea
ee-fy
cg-hf
rs-hw
zk-yy
vx-gz
mr-ai
cw-hf
vd-no
tn-jx
ih-mj
tk-aq
tb-fy
am-at
lb-xw
iv-et
xf-tw
ac-ez
ts-pa
fo-vm
nl-yi
hf-sj
ko-jp
mj-vc
ih-on
nk-dm
ew-dk
ry-rw
gr-cm
ii-dv
np-bl
fu-hq
jr-dw
aj-db
wk-vj
gv-hi
wb-ny
nk-ge
pw-il
ng-mq
ox-ad
ma-gf
xt-ic
kz-lw
qk-pl
aw-es
qo-kd
mr-vb
ne-me
af-tz
dv-vc
yh-tt
yo-mu
te-ui
ux-bj
gn-wu
hx-qg
wt-mt
cm-pv
iv-dy
oh-qp
qt-bo
nm-fu
iv-yb
mb-zo
tl-ho
ll-eq
bc-ge
qb-lw
aw-cy
ac-gi
ze-na
tp-qx
tk-ij
sd-ap
tc-mu
za-vo
hk-im
ow-xb
yt-em
mc-gh
kf-dz
pd-ee
da-sg
tr-ax
dn-wi
sd-nw
pv-lx
iy-fc
vz-kg
dl-op
eu-oq
tu-wd
ab-qg
bo-yd
ji-nq
lp-ak
gr-lx
pl-eq
ky-mq
cm-qf
cg-mu
nf-kh
fv-lu
vt-kd
tr-hw
rb-zm
gq-zt
mw-dp
ox-yy
ax-no
rq-uj
lc-wg
da-yi
tn-tj
kn-np
lr-ao
km-ac
nk-iw
ag-xj
rl-cd
bf-wi
gv-tk
yp-dk
qb-ze
vj-fh
qa-iy
yr-nb
lw-kl
dn-vv
bh-yw
nt-bb
tf-wy
wt-ss
iu-pf
my-di
tc-kw
hk-eb
dx-op
pd-fo
ez-vz
if-ug
sc-ku
bo-ta
xe-fw
mi-aq
sf-kd
ws-hy
jn-zo
oy-ty
fm-hf
ls-ay
zv-yw
yc-zn
yv-tt
eb-gz
ir-oy
li-yb
dh-bw
dj-ag
vt-wm
rd-ui
tk-ap
iu-jn
on-pl
ql-ee
ez-kg
qw-bl
md-zm
bv-sj
cl-hp
ux-um
ed-pu
ys-ps
vu-bp
ay-pw
vh-mr
wz-xb
id-ny
on-mj
ky-ux
wo-dh
za-ov
yc-yy
jq-lx
lf-nk
yh-je
co-la
av-dd
yc-zk
zv-jz
ak-vv
dt-js
qj-io
oh-dq
ep-zb
gj-pe
xf-gc
io-gf
wz-um
av-di
cy-yv
ez-zb
yc-pf
zk-pf
ob-pc
oz-ir
ko-rz
we-kd
de-qj
si-oe
nw-nz
gl-ov
yf-at
bz-vg
dp-kt
bu-el
zt-vg
je-tt
gg-ok
iy-pf
bd-cb
lp-dn
sg-nl
wb-dm
gv-sd
vd-gp
ag-fu
vh-rv
an-zo
rq-dn
fz-ia
rd-yd
tl-wg
um-or
fa-ha
uk-sr
lk-oh
bx-gc
cd-nt
rs-vt
ui-pu
bj-mq
yd-ed
fq-lq
fe-po
et-pi
ih-ex
fw-sa
xa-hu
aj-ah
rs-hh
dm-id
av-ot
zx-jk
mz-er
ci-mt
nt-fd
km-zl
zv-oq
fr-mr
bo-ur
jw-bk
mc-nz
nl-hy
se-lo
va-kt
mt-cd
di-zx
ba-qi
ds-ox
oq-tx
mp-bz
tt-ho
ub-gn
jn-lo
nw-aq
ok-ds
np-ag
cq-iv
lu-bp
jw-mq
ko-wo
jc-yn
pu-ur
wq-jz
jy-ob
kd-wm
jj-rn
es-ya
aa-fz
no-as
lr-ne
cu-cs
lm-eb
ne-ix
ao-sh
th-kz
er-ge
ex-vc
ah-ec
ib-yb
ck-rs
zv-ne
vv-es
mb-vg
gg-vp
in-xo
th-em
ev-ur
zl-ac
fr-jh
tr-wm
ng-ty
ge-fx
ox-nn
op-dt
nb-yz
kn-do
jd-np
xz-fv
yz-jm
cw-mu
ee-fp
ha-ps
qy-sj
yj-uh
oz-fe
cy-eq
vm-xz
to-dq
ci-fw
de-zi
wh-uv
yc-xo
lw-mj
it-sk
xl-ll
dl-xw
yl-je
zs-wk
ls-ec
lk-pb
jz-wr
et-ib
nn-yy
ba-bs
tj-xb
ox-iy
mc-oe
de-wk
pc-oc
oz-dp
sy-jr
yi-oy
so-xz
ro-sg
ma-fh
lq-cx
jr-fy
rr-cq
yz-kk
ah-ik
ny-iw
xc-pw
lt-ml
lw-th
oj-ge
zn-ox
rr-kq
es-wi
rn-jh
uf-xm
ar-aa
gv-ap
bn-uh
gj-op
ke-xi
bc-zc
jh-rv
oz-po
se-zt
qj-wk
oc-nv
tp-fu
na-ei
ef-pw
oj-vb
ip-vt
us-an
dz-nv
im-yv
wy-fq
ky-jw
ia-aa
ko-av
na-kl
hj-if
bd-il
mp-zo
zc-ny
sf-tr
ak-yb
nq-za
xb-um
zx-jp
gw-al
pl-jd
mu-hf
hy-tz
rw-tt
kj-lj
tb-tg
fq-gs
sa-gp
bh-ne
xd-yn
mr-rv
fq-cx
dc-ey
kw-nh
ob-xp
so-ee
xf-ig
kw-bv
sr-tm
nq-aa
dq-hq
fx-fo
xh-zd
ld-pe
av-bw
im-gz
cm-wl
ir-ig
fk-bn
fk-jl
wb-ge
tg-un
kf-hj
oq-wq
uj-um
rv-oj
ee-ob
xt-gj
gf-fh
uv-hj
zj-gr
zr-gw
ef-uh
fw-no
es-bf
rr-dy
nq-ar
ew-od
lb-ic
un-it
oz-uf
xl-qk
zg-mq
nf-sc
nv-jy
pq-iq
ub-wu
vp-jq
tl-yv
ux-ha
kj-sa
qs-ou
nh-bv
og-fe
al-qu
vb-rn
aa-dw
yl-pw
hk-sh
mp-iu
pp-xh
ha-zg
gf-wk
ip-ju
vm-ql
hh-sf
lk-xa
pl-yi
lc-yh
xd-fv
ty-ir
kj-vd
ro-zg
jy-vw
ff-ou
ep-vz
ay-il
xe-ce
vm-ee
wr-cl
ng-ir
al-bu
yw-me
kt-oy
lk-dq
me-ix
iv-rf
as-ou
vx-uf
hq-kn
mu-fm
mp-pz
ju-wm
yo-kw
kr-dp
aw-tl
ik-aj
th-qw
mk-yd
ib-pi
wu-ve
yr-yn
qu-sr
ne-jz
yk-tf
vd-lj
ag-zq
du-tx
xe-no
op-ld
tl-ym
tv-pn
hf-kw
ne-eu
nl-tz
qx-sh
ma-ey
lq-tv
zl-iq
sj-xb
iq-kg
ar-dw
dk-md
hx-sc
zr-el
uk-ja
vt-we
kh-ab
jm-nb
hr-vx
vg-qx
vp-zj
ed-fj
xc-ah
gi-pq
lt-vw
np-qx
nm-ag
hj-ut
fo-fy
dc-fi
gl-oe
bf-zh
or-jx
fa-bk
lp-vv
ds-yc
us-bn
bb-ci
zv-tx
db-ec
mp-gq
zr-gt
el-qu
mw-lx
dq-ub
hp-ob
ig-gc
nm-qx
bf-mo
ie-vl
zv-eu
kn-fu
iu-ww
gb-ex
vl-ub
ea-ut
js-lb
ie-ve
no-kj
pw-am
jb-cv
dl-pm
sv-kq
wk-dc
il-ik
wm-ck
vo-jr
yt-op
to-lk
jc-yr
dp-oy
xm-kt
qg-nf
lo-vg
xo-bf
pa-ow
kw-fm
fo-fp
hw-qd
mt-gy
oz-il
ho-bj
we-sf
ec-yl
cv-uh
qg-kh
la-ff
gb-ii
ip-hw
cm-cf
ro-ux
ss-rl
of-zc
oz-ty
ir-va
dl-qh
nf-jf
pp-xd
pc-vd
gw-uk
jx-tj
sr-ja
tu-bn
hh-tr
uv-sk
yb-pi
ba-si
hc-jm
hj-sk
ys-fa
cj-sy
wa-dv
xe-lj
rf-pi
ox-ym
pd-xz
cx-pn
wr-hp
pp-yr
cl-ed
ge-az
fz-vf
hx-tw
nt-uu
tz-da
nq-jr
hl-jh
un-fp
im-lm
fk-tu
cc-qo
ys-ro
yz-hc
ek-uu
gi-vu
xb-uj
xw-dx
ym-tt
ia-ji
al-uk
im-sh
bd-ay
il-yl
np-tp
ao-vx
vf-ln
gv-mi
qt-mk
pv-vp
md-co
qj-fh
pc-jy
dw-fz
gq-lo
bx-tw
vz-vu
qb-ei
is-uj
ry-yh
iu-gq
hk-hr
ox-pf
oj-mr
od-dk
tc-yo
pw-db
pu-bo
vo-ji
xm-fe
zx-dd
hu-lk
jl-jb
xe-wh
jf-ku
zi-vj
mj-wa
ld-xw
tx-lr
li-ib
fo-tb
aa-ji
yf-am
wr-gs
id-wb
hq-ag
ki-mw
qs-yp
ws-pl
xt-ld
ea-wh
er-lf
eo-jl
ln-sy
bw-dd
pb-ie
ky-bj
tz-ws
oh-hu
yf-mj
cx-tv
zh-mo
if-dz
af-pl
ik-ec
nl-qk
ty-aw
hk-lm
gn-ie
qd-vt
bn-jb
rw-je
ma-io
ax-kj
vh-ap
ou-zm
tn-or
jd-hq
wl-ok
pn-cj
zj-wl
rv-vb
bc-wb
kk-jc
pl-da
gn-oh
pj-fp
hy-da
vy-es
jl-wd
dh-dd
bw-zx
qj-ey
ew-rb
ck-sf
ku-xf
sk-ug
xj-nm
xz-tb
ma-vj
cb-ay
tx-bh
rl-wt
lf-az
wu-lk
gq-mb
kq-rf
iv-li
wo-jk
ya-xo
vm-ko
cd-gy
kk-yn
fr-vb
du-lr
lu-jc
qt-pu
uf-ty
ve-bd
ek-wt
gv-mg
dk-or
ey-wk
er-fx
hy-qk
fu-zq
tu-yj
dh-av
mz-gh
un-ql
zn-ad
eb-cs
by-wa
ao-eb
mg-fu
bv-qy
ka-yf
ou-co
am-by
ve-xa
bb-cd
mp-zt
ff-od
xi-mc
zg-ys
uu-cd
mc-mz
ma-wk
jl-yj
km-kg
fj-mk
bf-ak
xd-nb
cl-fq
se-ww
nz-mg
fi-de
wl-vp
ej-cd
vj-fi
wc-yn
di-ot
sk-ut
lx-ok
ei-ey
xp-xh
ej-nt
ry-yv
hu-gn
xo-mo
iw-zc
wc-hc
xi-qi
ap-of
pz-jj
rd-ev
se-jn
or-ts
um-tj
it-dz
ek-nt
dh-zx
we-ip
qd-sf
hu-ve
mo-zo
kf-mt
yk-pn
du-pj
ma-ld
eo-us
tg-xz
zk-ad
vx-gj
yx-hr
lt-xh
cl-wy
wr-wy
lz-ad
em-ze
gn-pb
or-pa
ds-qa
ri-bs
zr-tm
ed-ui
tk-ly
bv-nr
qf-ki
nr-sj
ec-ay
dk-ff
yz-yr
vw-pc
pz-rv
ki-vp
bs-mz
lj-ta
lx-ki
lp-in
mp-jn
qk-eq
bs-qi
ug-it
zv-lr
ia-vo
hu-vl
jk-av
wy-km
az-bc
ub-qy
ec-pw
tr-ju
zl-vu
wr-fq
jp-bw
sd-ly
xc-aj
fy-fp
qw-ei
jf-tt
qo-sk
eo-yj
sf-hw
hl-qp
ry-ho
et-cq
jj-vh
bv-yo
pi-cq
dt-lb
cb-yl
kg-bp
bl-na
uv-ea
uf-ng
lb-nm
hi-sd
vl-gn
gs-cl
ai-jh
qt-xg
sd-mi
wl-mw
ik-vv
ld-gj
pn-fq
jd-xj
gc-nf
mt-fd
pp-yn
ck-we
ri-ov
ub-lk
rl-wo
oy-fe
db-nh
kg-gi
yf-wa
hl-xj
aq-ap
yw-wq
bx-sc
ff-co
wa-vc
jh-vh
af-sg
gs-cx
sl-ky
lu-yn
ag-tp
il-xc
me-eu
xj-fu
tc-sj
pc-td
ix-yw
uj-jx
jx-rq
dh-jp
mj-by
iy-zn
qy-cw
ho-cy
vm-tg
zq-dj
ie-xa
ri-gl
lj-as
pc-lt
lf-fx
ao-ka
zj-gg
ro-sl
vy-wi
xw-ic
xo-lp
xe-kj
ah-nn
gl-dx
vp-mw
tv-wy
fe-va
pe-qh
hl-ai
kz-ei
xg-bb
gq-jn
iy-ds
em-qb
qw-em
ck-rc
lx-vp
ey-zi
bk-js
zq-xi
ej-ss
el-gt
vw-oc
gl-qi
vu-pq
fm-tc
bv-mu
np-dj
oz-kt
xp-vl
oe-ov
ve-lk
mr-qp
wu-hu
hh-fd
ri-ab
nv-xh
zg-bk
zh-vy
nz-mi
dv-on
dx-ic
qi-ov
gj-dl
id-bc
wq-du
sx-jl
po-lz
ls-lx
ck-ju
iw-bc
ai-fr
qh-xw
bs-ov
jm-lu
yd-ur
yz-wc
bd-aj
ll-yi
ho-je
jp-wo
wd-eo
rn-mr
iy-lz
yt-kl
ve-dq
zr-qu
cv-wd
nk-az
si-qi
bj-fa
to-ub
lf-ge
hx-jf
ew-md
yb-sv
wr-cj
dl-js
ba-gl
ew-ff
bc-nk
pw-aj
ia-dw
ln-vo
oh-ie
kj-as
vz-iq
vl-xa
of-mg
lj-fw
yp-ew
hx-ig
cb-iv
ql-so
aj-cb
de-ma
fi-lk
dz-qo
rd-bo
ax-sa
qd-jk
lw-ze
ov-mc
un-pd
xt-dx
sg-eq
po-ty
iw-wb
lu-xd
pp-hc
dw-ji
mz-ke
gp-fw
cq-ib
at-on
ah-il
dj-jd
do-dj
xt-lb
qb-kl
cs-ao
pc-xh
sx-jb
kh-sc
pv-ju
zx-kj
tg-fy
dp-po
ip-tr
ya-dn
hl-mr
bp-ez
rb-qs
ng-kt
ku-gc
yj-ef
zc-dm
ut-qo
ll-sg
vz-zl
gw-pm
ze-yt
ub-ve
hl-fr
yx-cs
et-yb
ur-ut
sl-ys
dv-yf
si-ri
te-xg
lm-cu
as-vd
nw-of
ag-do
zb-vu
uj-wz
zc-id
ww-mp
lu-wc
tj-is
di-dh
yh-cy
dy-cq
lk-gn
vp-ok
nr-az
xt-pe
id-ku
oe-ri
ha-kl
lu-kk
xd-hc
nf-ig
tf-gs
je-lc
af-xl
dq-wu
qs-co
ew-la
cy-wg
bh-zv
pp-jc
ij-ap
he-co
um-ow
ez-gi
cb-db
xm-va
az-id
iq-vu
bv-fm
ig-kh
zb-iq
xl-da
ie-dq
oc-ob
dw-jp
ob-vw
ot-bh
lx-cm
se-iu
ey-fh
mg-ap
aw-wg
ke-ri
tk-mi
vd-fw
pa-xb
do-xj
an-gq
dl-lb
jk-jp
ef-wd
di-dd
fk-eo
cl-cx
dv-by
xf-hx
ll-nl
gl-gh
pd-ql
ar-ln
de-wb
tb-pd
js-qh
as-sa
ii-vy
zv-ix
ih-zg
ni-sa
sr-pm
cd-ci
fk-yj
nz-ly
te-pu
dv-ih
zq-nm
al-gt
js-ld
wd-jb
cs-hr
rz-zx
eb-yx
yk-gs
pf-zn
ji-fz
lp-mo
tc-hf
vo-dw
vv-wi
yz-xd
fy-so
gz-sh
gw-cw
wg-ho
yl-db
ya-vy
kh-ku
qw-da
vj-qj
ko-bw
qp-rn
za-ia
hi-mi
tx-yw
kq-pi
ay-db
fy-un
pp-kk
sk-kf
zd-td
rl-ci
yc-iy
ii-at
za-ji
qh-ld
zo-ww
eb-hr
nb-yn
qp-vb
ys-bk
wc-ss
fz-ar
ta-ni
aw-rw
zn-yy
fy-ql
ps-ro
fk-rn
wk-zi
jr-ln
li-rm
zm-ew
sx-wd
qh-gj
ey-io
si-ww
eu-jz
ik-ay
bb-ek
yd-fj
ww-zt
ts-ow
fx-id
ur-mk
nn-fc
nf-ab
gy-ek
ii-yf
wm-rs
fd-ci
tx-jz
nm-jd
vh-vb
aq-ys
km-ez
ri-gh
us-yj
yz-lu
an-mp
mq-ro
ff-we
zj-to
pv-zj
sr-el
my-jp
hk-cs
ej-wt
tn-wz
ka-tz
vv-vy
kd-ck
oy-ng
ow-tj
cm-gg
qt-vf
pf-nt
ko-zx
rq-ts
qu-pm
jl-uh
vx-yx
ep-bp
um-rq
sv-li
qh-op
za-vf
tp-do
pa-um
sy-za
xp-td
zg-bj
xz-ee
um-jx
hl-pz
hc-yr
xj-tp
sc-gc
xc-ls
fp-pd
es-dn
sf-ip
it-ea
yd-ev
uk-gt
cx-wr
wh-it
hr-sh
ow-rq
vf-ji
da-ws
ty-dp
yj-jb
fc-yc
ii-by
nz-ap
ma-jh
wm-me
am-mj
pn-tf
fo-ee
xm-dx
ln-nq
ri-xi
jc-xd
gz-cu
wy-pn
jw-ys
pu-ne
av-wo
qg-ai
yj-gn
yd-qt
tz-xl
xc-se
sg-tz
lm-hr
tn-is
sg-qk
tm-gt
fh-io
vy-in
ao-cu
ai-vh
tt-cy
mz-gl
fu-do
nq-dw
rl-uu
tk-hi
ej-gy
tk-nz
ya-vv
ja-zr
vj-dc
wz-is
eq-da
qj-zi
dz-sk
sy-vf
ws-ll
ly-ij
cq-rm
mo-vv
kn-qx
or-xb
oh-vl
ho-yv
jq-mw
ww-an
es-zh
ay-aj
nf-xf
fc-zn
nt-ss
ec-bd
ea-cc
dl-ld
uf-kt
fp-ev
nn-iy
jm-yn
na-kz
fv-fj
cc-dz
el-ja
ep-pq
fi-qj
ka-cu
wd-fk
rl-fd
kn-ag
ed-qt
rl-ej
yj-bn
nr-mu
ah-yl
ml-xp
pp-lu
vj-zs
ne-du
dm-bc
ev-bo
kk-nb
cf-gt
ij-aq
in-dn
ar-ji
qo-if
jw-bj
vd-ax
ff-yp
lr-oq
of-aq
yk-fq
ea-qo
xh-rc
lu-yr
ix-oq
xd-ne
yh-ym
gp-ta
nq-vf
tb-so
xt-qh
lx-zj
ap-mi
pw-ik
ve-gn
mu-kw
bj-bk
et-dy
dy-vp
vv-in
ig-ab
da-ll
hy-ll
vj-ey
yb-rm
hh-qd
ve-pb
pq-ez
zi-hy
fe-kt
ac-kg
ik-db
jc-hc
bl-og
qd-ck
by-at
hu-pb
mb-mp
yt-qw
et-li
ry-wg
xi-mz
ag-wb
jy-lt
sr-zr
pv-qf
dk-co
sr-gt
wq-bh
jc-yz
gq-bz
vy-mo
aj-yl
pd-tg
wo-di
bw-nv
mg-mi
dt-gj
du-eu
wd-bn
nh-mu
wm-ip
tc-bv
qj-dc
qj-dh
me-jz
qb-th
ii-dl
zd-pc
qy-kw
vx-cs
kd-qd
kg-zb
kh-gc
cu-yx
ic-gj
qt-ur
on-by
us-jl
jy-zd
vm-fy
xt-dl
ii-wa
kn-tp
sl-ha
vw-ml
at-dv
cf-tm
wh-sk
pn-wr
ls-ik
oz-va
zd-yw
je-ac
ss-ci
fq-di
cv-ef
mb-bz
qb-og
iu-vg
xl-hy
tn-ts
hu-cq
nh-nr
lb-gj
lc-rw
hj-it
mk-bo
vu-md
xi-gh
ov-si
ni-gp
us-wd
tc-qy
ur-ed
mw-pv
sl-hk
qt-te
oc-ml
yv-rw
jj-qp
jq-gg
te-yd
se-mp
fd-ss
mz-qi
tp-jd
jj-oj
gn-xa
ws-sg
ax-gp
ir-kt
in-jj
lj-sa
zv-du
rb-dk
uh-us
tk-mg
rb-md
cm-zj
nv-pc
ym-rw
la-ou
gp-ce
of-nz
hr-ao
nh-fm
yi-sg
fp-ql
to-hu
kr-oy
kf-cc
gs-wy
ew-ou
ih-at
ze-kz
jl-bn
tw-ku
aa-vf
ir-kr
aw-lc
vj-io
vw-xh
pu-rd
zx-av
cm-ok
ym-je
yx-lm
yd-xg
jr-ar
xp-pc
dq-gn
xg-bo
za-jr
hc-ar
rf-dy
kk-jm
ei-ze
yx-gz
vc-on
nr-fm
vy-lp
sf-ju
is-pa
mi-vl
zn-nn
my-ko
qa-lz
cf-zr
oe-qi
qg-xf
zm-dk
ko-dh
qt-ui
wl-gg
vg-fm
mr-yo
gf-zi
ic-dt
ui-ev
fv-kk
jk-dh
bv-hf
to-gn
vp-qf
zj-jq
rd-mk
fp-tb
an-zt
nb-wc
pz-fr
nn-ds
tt-aw
qf-jq
lf-dm
zh-vv
sl-zg
qs-dk
zk-ox
tv-fq
ku-qg
el-tm
bo-fj
xc-ay
hu-dq
bx-hx
dn-bf
dv-ex
ya-tf
ws-eq
gi-zb
ak-vy
rw-jq
fx-zc
ep-iq
qd-we
tt-tl
di-ko
bf-in
oc-zd
mc-si
zk-lz
ba-ov
fz-nq
bx-ig
fd-uu
ww-mb
li-rf
tp-dj
qg-bx
rz-jp
gy-pj
gg-vc
ut-cc
se-et
tr-we
vm-tv
qs-zm
hf-sv
ig-qg
hf-qy
of-tk
qi-ri
ip-hh
ay-ah
dc-fh
tm-qu
is-jx
dm-ge
ko-jk
rr-pi
fe-ir
xl-pl
qg-gc
rb-ff
fj-xg
wc-kk
or-ow
se-bz
fo-pj
uk-cf
sh-cu
gs-cj
zh-ak
ap-ly
eq-xl
ai-rv
tl-lc
ow-mb
gy-ss
qa-ad
cg-yo
lr-jz
fa-mq
qy-fm
hh-kd
qb-bl
nv-xp
hx-gc
da-qk
yw-oq
dx-qh
wq-lr
lz-yy
ot-dh
vb-ai
rr-ib
qu-yx
bu-gw
ub-pb
sg-hy
xt-dt
bd-xc
ja-gt
rq-tn
mg-ll
hr-cu
xg-mk
xc-ec
tf-wr
nb-lu
ds-zk
gb-ih
ln-ji
wr-tv
qs-md
ld-dx
cc-it
cv-tu
ge-ny
ta-fw
uh-jb
am-ii
ux-ys
fc-zk
hj-cc
wa-at
vm-so
ia-sy
we-wm
nm-tp
hq-do
bb-ej
xh-jy
kf-ea
qk-yi
rr-zk
is-xb
lt-xp
ho-lc
gs-hp
pw-cb
ml-pc
it-kf
el-gw
ev-pu
cg-nh
ea-ug
ix-du
so-un
na-yt
jy-td
uu-mt
si-mz
ou-he
zj-ki
jr-fz
it-uv
ih-vc
xw-gj
oq-me
qd-tr
qk-ll
xe-as
ly-aq
jb-us
jq-wl
bd-ah
yw-jz
rq-is
hi-bx
fq-tf
iu-an
rc-xp
lr-eu
kn-dj
fz-vo
zj-ok
ql-pj
xe-ax
vb-pz
dz-ea
af-eq
oy-xm
kt-ty
vb-jh
wi-ak
gv-nw
oj-hl
qf-ok
iu-bz
vf-jr
gl-mc
qs-oc
xe-vd
jl-tu
nb-hc
bk-ha
rz-bw
jq-ok
xm-ty
qf-gr
zd-ob
wg-kq
yk-cj
ro-bj
pp-jm
hj-ug
jw-zg
ie-bz
aw-yh
pd-fy
va-li
ix-eu
io-wk
ts-ij
ok-mw
pe-op
ds-pf
vo-ip
by-cj
og-lw
ni-no
mc-qi
zm-he
sx-cv
ef-eo
tt-lc
mq-ux
jw-ba
ds-ad
zn-ds
bo-ly
sx-fk
je-yv
ey-de
fk-us
uu-ss
oz-xm
cd-cx
wl-hr
mq-ys
ng-xm
kn-zq
bk-ps
nw-ly
ka-yx
wz-pa
dx-lb
ok-gr
gr-ki
ie-to
qw-kl
do-np
ff-zm
mk-te
sv-dy
kh-jf
du-jz
sj-cw
ia-vf
sk-lq
fh-zi
bk-ux
bx-nf
lo-an
to-vl
el-cf
kq-dy
jf-xf
ab-sc
ur-rd
ek-ci
js-gj
lb-pe
cj-tf
ma-dc
uj-io
vh-fr
tj-wz
wr-yk
dt-dx
wu-to
mi-ij
tn-um
zd-xp
ri-ba
we-ju
dz-hj
vo-ar
sr-fc
sc-na
tx-yp
bl-yt
ku-hx
yn-hc
im-cu
vw-td
wq-ug
lf-zc
xi-oe
wt-fd
wr-lq
gf-hx
gr-vp
ze-og
oe-ba
cf-bu
rz-dh
ex-wa
jp-av
me-wq
ci-gy
bw-my
ke-gl
tr-vt
ej-fd
zi-dc
ah-cb
mk-ev
cv-jl
ug-qo
ih-am
po-ng
nq-ia
fk-cv
ob-rc
wd-ad
lr-ix
zx-wo
ma-fi
af-yi
ir-uf
du-yw
ej-ek
je-ry
rd-fj
dm-az
jd-do
am-dv
mq-sl
xf-eb
xz-ql
xw-js
so-md
vx-sh
cq-rf
sy-fz
nr-tc
ef-jb
nq-vo
aj-ec
ei-th
xa-wu
gq-vg
zl-kg
rf-yb
gl-bs
ju-vt
bu-bf
nw-mg
ja-ay
ig-sc
hk-ka
db-ls
mk-pu
uf-fe
sd-zt
rn-hl
ak-ya
yw-eu
pm-zr
my-ew
tx-me
ww-lo
hc-kk
th-na
th-yt
at-mj
ix-jz
xo-es
dc-lo
es-ak
bn-sx
yd-zb
di-jk
yv-aw
tn-pa
bh-lr
wy-cj
ij-nz
mg-hi
ef-sx
wh-if
uk-el
ow-tn
yz-pp
tz-yi
im-eb
fp-tg
xo-zh
yy-iy
ba-uj
rm-yn
wh-ug
no-ta
ky-ha
as-ta
af-ll
cw-tc
ps-ky
qd-rs
tl-je
mt-ej
mt-ek
ds-fc
tb-pj
ex-by
yc-qa
zh-pv
bo-te
ep-ac
dt-xw
cw-bv
""";

var lines = input.Split("\r\n");
var connections = GetConnections();
var connectionDictionary = GetConnectionDic();
var networks = new List<HashSet<string>>();
long total = 0;

foreach (var cpu in connectionDictionary.Keys)
{
    if(cpu.StartsWith('t'))
    {
        MapConnections(cpu);
    }
}


Console.WriteLine($"There are {total} sets of tree");

void MapConnections(string cpu0)
{
    var connectedToCpu0 = connectionDictionary[cpu0].ToArray();
    

    for (var i = 0; i < connectedToCpu0.Length - 1; i++)
    {
        for (var j = 1; j < connectedToCpu0.Length; j++)
        {
            var cpu1 = connectedToCpu0[i];
            var cpu2 = connectedToCpu0[j];

            if ((connections.Contains((cpu1, cpu2)) || connections.Contains((cpu2, cpu1))) && !IsAlreadyCounted(cpu0, cpu1, cpu2))
            {
                var network = new HashSet<string>();
                network.Add(cpu0);
                network.Add(cpu1);
                network.Add(cpu2);
                networks.Add(network);
                Console.WriteLine($"{cpu0}, {connectedToCpu0[i]}, {connectedToCpu0[j]}");
                total++;
            }
        }
    }
}

bool IsAlreadyCounted(string cpu0, string cpu1, string cpu2)
{
    foreach(var network in networks)
    {
        if(network.Contains(cpu0) && network.Contains(cpu1) && network.Contains(cpu2))
        {
            return true;
        }
    }

    return false;
}

bool HasTConnection((string cpu1, string cpu2) connection)
{
    return connection.cpu1.StartsWith('t') || connection.cpu2.StartsWith("t");
}

(string cpu1, string cpu2)[] GetConnections()
{
    var connections = new HashSet<(string cpu1, string cpu2)>();
    
    foreach (var line in lines)
    {
        var matches = Regex.Matches(line, "([a-z]+)");
        var cpu1 = matches[0].Value;
        var cpu2 = matches[1].Value;

        if(!connections.Contains((cpu2, cpu1)))
        {
            connections.Add((cpu1, cpu2));
        }
    }

    return connections.ToArray();
}

Dictionary<string, List<string>> GetConnectionDic()
{
    var connections = new Dictionary<string, List<string>>();

    foreach (var line in lines)
    {
        var matches = Regex.Matches(line, "([a-z]+)");
        var cpu1 = matches[0].Value;
        var cpu2 = matches[1].Value;

        if(connections.ContainsKey(cpu1))
        {
            connections[cpu1].Add(cpu2);
        }
        else
        {
            connections.Add(cpu1, new List<string> { cpu2 });
        }

        if (connections.ContainsKey(cpu2))
        {
            connections[cpu2].Add(cpu1);
        }
        else
        {
            connections.Add(cpu2, new List<string> { cpu1 });
        }
    }

    return connections;
}






