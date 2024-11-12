import http from 'k6/http';

export const options = {
    vus: 100,
    duration: '30s',
}

export default function () {
    const url = 'http://localhost:5105/api/cached/default'
    const response = http.get(url)
}
