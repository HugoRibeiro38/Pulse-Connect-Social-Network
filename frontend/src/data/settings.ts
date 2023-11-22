import {
	AtSign,
	Bell,
	Contrast,
	Cookie,
	HeartCrack,
	HeartHandshake,
	HelpCircle,
	Info,
	KeyRound,
	Languages,
	LogOut,
	type LucideIcon,
	Mail,
	User,
} from 'lucide-react';

import { APP_ROUTES } from '@/routes/app';

export type SettingsItemProps = {
	href: string;
	label: string;
	text: string;
	icon: LucideIcon;
};

export type SettingsItemsProps = Record<string, SettingsItemProps[]>;

export const settingsItems: SettingsItemsProps = {
	General: [
		{
			href: APP_ROUTES.SETTINGS.GENERAL.ACCOUNT,
			label: 'Account Informations',
			text: 'Update your account information and personalize your profile.',
			icon: User,
		},
		{
			href: APP_ROUTES.SETTINGS.GENERAL.NOTIFICATIONS,
			label: 'Notifications',
			text: 'Configure your notification settings for a personalized experience.',
			icon: Bell,
		},
		{
			href: APP_ROUTES.SETTINGS.GENERAL.APPEARANCE,
			label: 'Appearance',
			text: 'Customize the appearance of the application to suit your preferences.',
			icon: Contrast,
		},
		{
			href: APP_ROUTES.SETTINGS.GENERAL.LANGUAGE,
			label: 'Language',
			text: 'Choose your preferred language for the application interface.',
			icon: Languages,
		},
	],
	Account: [
		{
			href: APP_ROUTES.SETTINGS.ACCOUNT.INTEGRATIONS,
			label: 'Integrations',
			text: 'Integrate third-party services to enhance your account functionality.',
			icon: AtSign,
		},
		{
			href: APP_ROUTES.SETTINGS.ACCOUNT.EMAIL,
			label: 'Change Email',
			text: 'Update your email address associated with your account.',
			icon: Mail,
		},
		{
			href: APP_ROUTES.SETTINGS.ACCOUNT.PASSWORD,
			label: 'Change Password',
			text: 'Secure your account by regularly updating your password.',
			icon: KeyRound,
		},
		{
			href: APP_ROUTES.SETTINGS.ACCOUNT.DISABLE,
			label: 'Disable Account',
			text: 'Temporarily disable your account while retaining your data.',
			icon: HeartCrack,
		},
	],
	Others: [
		{
			href: APP_ROUTES.ABOUT,
			label: 'About Us',
			text: 'Learn more about our mission, vision, and the team behind the application.',
			icon: Info,
		},
		{
			href: APP_ROUTES.HELP,
			label: 'Help & Support',
			text: 'Get assistance and support for any issues or inquiries you may have.',
			icon: HelpCircle,
		},
		{
			href: APP_ROUTES.TERMS,
			label: 'Terms & Conditions',
			text: 'Read and understand the terms and conditions governing the use of the application.',
			icon: HeartHandshake,
		},
		{
			href: APP_ROUTES.PRIVACY,
			label: 'Privacy Policy',
			text: 'Understand how your data is handled and protected by reviewing our privacy policy.',
			icon: Cookie,
		},
		{
			href: APP_ROUTES.AUTH.SIGNOUT,
			label: 'Sign Out',
			text: 'Securely sign out of your account to protect your privacy.',
			icon: LogOut,
		},
	],
};
