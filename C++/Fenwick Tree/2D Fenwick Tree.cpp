struct BIT {
    ll n{}, m{};
    ll bit[N][N] = {0};

    ll LSB(ll num) {
        return num & -num;
    }

    void update(ll x, ll y, ll val) {
        while (x <= n) {
            ll tmp = y;
            while (y <= m) {
                bit[x][y] += val;
                y += LSB(y);
            }
            y = tmp;
            x += LSB(x);
        }
    }

    ll query(ll x, ll y) {
        ll ret{};

        while (x > 0) {
            ll tmp = y;
            while (y > 0) {
                ret += bit[x][y];
                y -= LSB(y);
            }
            y = tmp;
            x -= LSB(x);
        }
        return ret;
    }


};
