struct BIT {
    ll n{};
    ll bit[N];

    ll LSB(ll num) {
        return num & -num;
    }

    void update(ll idx, ll val) {
        while (idx <= n) {
            bit[idx] += val;
            idx += LSB(idx);
        }
    }

    ll query(ll idx) {
        ll ret{};
        while (idx > 0) {
            ret += bit[idx];
            idx -= LSB(idx);
        }
        return ret;
    }

}
