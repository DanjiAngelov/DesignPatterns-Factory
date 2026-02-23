const NotificationCreator = require('./NotificationCreator');
const EmailNotification = require('./EmailNotification');

class EmailNotificationCreator extends NotificationCreator {

    createNotification() {
        return new EmailNotification();
    }
}

module.exports = EmailNotificationCreator;