## Security
### CORS
- Cross Origin Requests
- Mordern browsers only allow same origin requests for security purpose
- Same Origin 
    - http://www.abc.com/index.html
    - http://www.abc.com/aboutus.html
- Different Origins
  - https://www.abc.net
  - https://www.abc.com
  - tcp://abc.com
  - http:www.abc.com
  - https://www.abc.com:8085

#### Enable CORS
- There are three ways to enable CORS:
1. In middleware using a named policy or default policy.
2. Using endpoint routing.
3. With the [EnableCors] attribute.


### Authentication using JWT
- Authentication: user's identity is recognized
- Authorization: user is granted with access rights
- JWT: JSON Web Tokens
  - JWT has 2 parts separated by .
  - header.payload.signature
### Secrets Management
- to store sensitive/confidential data/environment/individual/application/centralized
- Hardcoded (not recommended at all), *Setting.json, Secrets file, Azure Key Vault (most recommended)
- Generate `Secrets.json` by **right clicking on the Api project** and click **Manage Secrets**
- the `Secrets.json` file is stored in `C:\Users\<username>\AppData\Roaming\Microsoft\UserSecrets\<GUID>`
- This  `Secrets.json` file is not pushed on source control and it is per individual basis