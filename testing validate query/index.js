import { validate } from './node_modules/mysql-query-validator/dist/index.js'

try {
    validate(`
        create table test (
          id varchar(20) not null,
          created_at datetime(6),
          slug varbinary(255),
          enabled tinyint(1),
          labels json // missing comma
          url blob
        )
      `)
} catch (err) {
    console.error(err.message) // syntax error at position N near 'url'
}