# JSON Web Token (JWT)
JWT stands for JSON Web Token. It is an open standard (RFC 7519) that defines a compact and self-contained way for securely transmitting information between parties as a JSON object. JWTs are commonly used for authentication and authorization in web applications and APIs.

A JWT token consists of three parts:

1. Header: The header typically consists of two parts: the type of token (JWT) and the signing algorithm being used, such as HMAC SHA256 or RSA. It is Base64Url encoded.

2. Payload: The payload contains the claims, which are statements about an entity (e.g., user) and additional data. There are three types of claims: reserved claims, public claims, and private claims. Some common reserved claims include "iss" (issuer), "sub" (subject), "exp" (expiration time), and "iat" (issued at time). The payload is also Base64Url encoded.

3. Signature: The signature is used to verify that the sender of the JWT is who it says it is and to ensure that the message wasn't changed along the way. It is computed by encoding the header and payload, concatenating them with a period ('.'), and then signing the resulting string with a secret key (for HMAC) or private key (for RSA). The signature is also Base64Url encoded.

A typical JWT token looks like this:

```
eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c
```

Here's a breakdown of the parts:

- Header: `eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9`
- Payload: `eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ`
- Signature: `SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c`

JWT tokens are often used in authentication workflows. When a user logs in to a web application, the server generates a JWT token containing the user's information (claims) and signs it. The client receives this token and includes it in subsequent requests to access protected resources on the server. The server then validates the token to ensure that it hasn't been tampered with and that it contains valid claims before granting access to the requested resources.